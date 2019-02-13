using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace SharpShader
{
    /// <summary>A thread-safe list implementation. Basically wraps thread-safety around the vanilla list.</summary>
    /// <typeparam name="T">The type of object to be stored in the list.</typeparam>
    [DebuggerDisplay("Count = {Count}")]
    internal class ThreadSafeList<T>
    {
        static readonly T[] _emptyArray = new T[0];

        T[] _items;
        int _count;
        int _capacity;
        int _version;

        object _locker;
        InterlockHelper _interlocker;

        /// <summary>
        /// Creates a new instance of <see cref="ThreadSafeList{T}"/>.
        /// </summary>
        public ThreadSafeList()
        {
            _interlocker = new InterlockHelper();
            _items = _emptyArray;
            _capacity = 0;
            _locker = new object();
        }

        /// <summary>
        /// Creates a new instance of <see cref="ThreadSafeList{T}"/>, initialized to a specific capacity.
        /// </summary>
        /// <param name="initialCapacity">The initial capacity of the list.</param>
        public ThreadSafeList(int initialCapacity)
        {
            if (initialCapacity < 0)
                throw new ArgumentOutOfRangeException("Cannot have a capacity less than 0.");

            _interlocker = new InterlockHelper();
            _items = new T[initialCapacity];
            _capacity = _items.Length; 
            _locker = new object();
        }

        public void Add(T item)
        {
            _interlocker.Lock(() =>
            {
                AddElement(item);
                _version++;
            });
        }

        private void AddElement(T item) {
            EnsureCapacityInternal(_count + 1);
            _items[_count++] = item;
        }

        /// <summary>Ensures the list has at least the minimum specified capacity.</summary>
        /// <param name="min">The minimum capacity to ensure.</param>
        public void EnsureCapacity(int min)
        {
            _interlocker.Lock(() =>
            {
                EnsureCapacityInternal(min);
                _version++;
            });
        }

        /// <summary>Internal method for ensuring capacity.</summary>
        /// <param name="min">The minimum capacity to ensure.</param>
        private void EnsureCapacityInternal(int min)
        {
            if (min >= _items.Length)
            {
                int newCap = _capacity == 0 ? 1 : _capacity * 2;
                if (newCap < min) newCap = min;
                SetCapacity(newCap);
            }
        }

        /// <summary>Sets the internal capacity of the list.</summary>
        /// <param name="value">The total capacity required.</param>
        private void SetCapacity(int value)
        {
            _interlocker.Lock(() =>
            {
                if (value != _items.Length)
                {
                    if (value < _count)
                        _interlocker.Throw<IndexOutOfRangeException>("Capacity must be greater or equal to the number of stored items.");

                    if (value > 0)
                    {
                        T[] newItems = new T[value];
                        if (_count > 0)
                            Array.Copy(_items, 0, newItems, 0, _count);

                        _items = newItems;
                    }
                    else
                    {
                        _items = _emptyArray;
                    }

                    _capacity = value;
                }
            });
        }

        public void Clear()
        {
            _interlocker.Lock(() =>
            {
                _count = 0;
                _version++;
            });
        }

        private void CopyToInternal(Array array, int index)
        {
            _interlocker.Lock(() =>
            {
                int targetAvailable = array.Length - index;
                if (targetAvailable < _count)
                {
                    _interlocker.Throw<IndexOutOfRangeException>("Target array does not have enough free space.");
                }
                else
                {
                    Array.Copy(_items, 0, array, index, _count);
                    _version++;
                }

            });
        }

        public bool Contains(T item)
        {
            bool found = false;
            _interlocker.Lock(() =>
            {
                if (item == null)
                {
                    for (int i = 0; i < _count; i++)
                    {
                        if (_items[i] == null)
                        {
                            found = true;
                            break;
                        }
                    }
                }
                else
                {
                    EqualityComparer<T> c = EqualityComparer<T>.Default;
                    for (int i = 0; i < _count; i++)
                    {
                        if (c.Equals(_items[i], item))
                        {
                            found = true;
                            break;
                        }
                    }
                }

                _version++;
            });

            return found;
        }

        public int IndexOf(T item)
        {
            int index = -1;
            _interlocker.Lock(() =>
            {
                index = Array.IndexOf(_items, item);
            });

            return index;
        }

        private void InsertElement(T item, int index)
        {
            if (index == _count)
            {
                AddElement(item);
            }
            else
            {
                if (index > _count)
                {
                    _interlocker.Throw<IndexOutOfRangeException>("Cannot insert beyond the number of items in the list.");
                }
                else
                {
                    EnsureCapacityInternal(_count + 1);
                    Array.Copy(_items, index, _items, index + 1, _count - index); // Move items in front up by one index.
                    _items[index] = item;
                    _count++;
                }
            }
        }

        /// <summary>Removes an item from the list.</summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            bool found = false;
            _interlocker.Lock(() =>
            {
                int index = Array.IndexOf<T>(_items, item);
                if (index > -1)
                {
                    RemoveElement(index);
                    _version++;
                    found = true;
                }
            });

            return found;
        }

        /// <summary>Removes an item from the list at the specified index.</summary>
        /// <param name="index">The index.</param>
        public void RemoveAt(int index)
        {
            if (index < 0)
                throw new IndexOutOfRangeException("Index cannot be less than 0.");

            _interlocker.Lock(() =>
            {
                if (index >= _count)
                    _interlocker.Throw<IndexOutOfRangeException>("Index must be less than the item count.");

                RemoveElement(index);
                _version++;
            });
        }

        private void RemoveElement(int index)
        {
            _count--;

            // If index was not the last element, update array structure to close gap.
            if (index != _count)
            {
                Array.Copy(_items, index + 1, _items, index, _count - index); // Move items ahead of the index, back one element.
                _items[_count] = default(T); // Clear last element, since it moved back by one index.
            }
            else
            {
                _items[index] = default(T);
            }
        }

        /// <summary>Gets or sets a value at the given index.</summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                T result = default(T);
                _interlocker.Lock(() =>
                {
                    if (index >= _count)
                        _interlocker.Throw<IndexOutOfRangeException>("Index must be less than item count.");
                    else if (index < 0)
                        _interlocker.Throw<IndexOutOfRangeException>("Index cannot be less than 0.");

                    result = _items[index];
                });
                return result;
            }

            set
            {
                _interlocker.Lock(() =>
                {
                    if (index >= _count)
                        _interlocker.Throw<IndexOutOfRangeException>("Index must be less than item count.");
                    else if (index < 0)
                        _interlocker.Throw<IndexOutOfRangeException>("Index cannot be less than 0.");

                    _items[index] = value;
                    _version++;
                });
            }
        }

        public override string ToString() => $"Count: {_count}";

        /// <summary>Gets the number of items in the list.</summary>
        public int Count => _count;

        public int Capacity
        {
            get => _capacity;
            set => SetCapacity(value);
        }
    }
}