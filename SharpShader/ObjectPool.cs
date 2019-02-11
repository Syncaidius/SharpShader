using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShader
{
    internal class ObjectPool<T> where T : IPoolable, new()
    {
        ConcurrentBag<T> _pool;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instantiationCallback">The callback to invoke when a new instance of <typeparamref name="T"/> is required.</param>
        internal ObjectPool()
        {
            _pool = new ConcurrentBag<T>();
        }

        public T Get()
        {
            T result;
            if (!_pool.TryTake(out result))
                result = new T();

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
