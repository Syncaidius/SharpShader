using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharpShader
{
    /// <summary>
    /// A Sharp Shader-specific thread manager.
    /// </summary>
    internal class ThreadManager : IDisposable
    {
        TranslationWorker[] _workers;

        /// <summary>
        /// A wait event for workers to rest at when there is no work.
        /// </summary>
        internal ManualResetEvent RestWait { get; }
        internal ConcurrentQueue<ShaderTranslationContext> WorkQueue { get; }

        internal ThreadManager(int workerCount)
        {
            WorkQueue = new ConcurrentQueue<ShaderTranslationContext>();
            RestWait = new ManualResetEvent(false);
            _workers = new TranslationWorker[workerCount];
            for (int i = 0; i < workerCount; i++)
                _workers[i] = new TranslationWorker(this);
        }

        public void Dispose()
        {
            for (int i = 0; i < _workers.Length; i++)
                _workers[i].Dispose();
        }
    }

    internal class TranslationWorker : IDisposable
    {
        ThreadManager _manager;
        Thread _thread;
        bool _exit = false;
        Stopwatch _timer;

        ManualResetEvent _dependentWait { get; } = new ManualResetEvent(false);
        ThreadSafeList<TranslationWorker> _workers = new ThreadSafeList<TranslationWorker>();

        internal TranslationWorker(ThreadManager manager)
        {
            _manager = manager;
            _thread = new Thread(DoWork);
            _timer = new Stopwatch();
        }

        internal void DoWork()
        {
            while (!_exit)
            {
                if(_manager.WorkQueue.TryDequeue(out ShaderTranslationContext sc))
                {
                    sc.AssignedWorker = this;
                    _timer.Start();
                    TranslationRunner.Message($"Translating {sc.Name}", TranslationMessageType.Status);

                    TranslationRunner.Message("Translating to {context.Language.Language}");
                    TranslationRunner.Translate(sc, sc.RootNode);
                    _timer.Stop();
                    TranslationRunner.Message($"  Finished '{sc.Name}' in {_timer.Elapsed.TotalMilliseconds:N2} milliseconds");
                    _timer.Reset();

                    // Let dependent workers know we're done with this shader translation so they can continue.
                    _dependentWait.Set();
                    SpinWait spin = new SpinWait();
                    while (_workers.Count > 0 && !_exit)
                        spin.SpinOnce();
                }
                else
                {
                    _manager.RestWait.Reset();
                    _manager.RestWait.WaitOne();
                }
            }
        }

        internal void WaitFor()
        {
            _dependentWait.WaitOne();
        }

        public void Dispose()
        {
            _exit = true;            
        }
    }
}
