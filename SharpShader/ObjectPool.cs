using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ObjectPool<T> where T : IPoolable
    {
        Func<T> _instantiator;
        ConcurrentBag<T> _pool;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instantiationCallback">The callback to invoke when a new instance of <typeparamref name="T"/> is required.</param>
        internal ObjectPool(Func<T> instantiationCallback)
        {
            _instantiator = instantiationCallback;
            _pool = new ConcurrentBag<T>();
        }

        public T Get()
        {
            T result;
            if (!_pool.TryTake(out result))
                result = _instantiator();

            return result;
        }

        public void Put(T item)
        {
            item.Clear();
            _pool.Add(item);
        }
    }

    internal interface IPoolable
    {
        void Clear();
    }
}
