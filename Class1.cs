using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    class CustomList<T> : IEnumerable, IEnumerator
    {
        private T[] _arr;

        public int Capacity { get; set; }

        public object Current => throw new NotImplementedException();
        public CustomList()
        {
        }
        public CustomList(int capacity)
        {
            Capacity = capacity;
            _arr = new T[Capacity];
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < _arr.Length)
                {
                    return _arr[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < _arr.Length)
                {
                    _arr[index] = value;
                }
            }
        }
        public void Add(T item)
        {
            if (Capacity != 0)
            {
                if (_arr[^1] != null)
                {
                    Array.Resize(ref _arr, _arr.Length + Capacity);
                }
                else
                {
                    for (int i = 0; i < _arr.Length; i++)
                    {
                        if (_arr[i] != null)
                        {
                            continue;
                        }
                        else
                        {
                            _arr[i] = item;
                            break;
                        }
                    }
                }
            }
            else
            {
                Array.Resize(ref _arr, _arr.Length + 1);
                _arr[^1] = item;
            }
        }
        public void Remove(T item)
        {
            T[] arr = new T[_arr.Length - 1];
            int j = 0; //arr index
            for (int i = 0; i < _arr.Length; i++)
            {
                if (item.ToString() != _arr[i].ToString())
                {
                    arr[j] = _arr[i];
                    j++;
                }
            }
            _arr = arr;
        }
        public void Remove(int index)
        {
            T[] arr = new T[_arr.Length - 1];
            int j = 0;
            for (int i = 0; i < _arr.Length; i++)
            {
                if (index != i)
                {
                    arr[j] = _arr[i];
                    j++;
                }
            }
            arr = _arr;
        }
        public void Clear()
        {
            _arr = new T[_arr.Length];
        }
        public bool Contains(T item)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (item.ToString() == _arr[i].ToString())
                {
                    return true;
                }
            }
            return false;
        }
        public void Remove()
        {

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
