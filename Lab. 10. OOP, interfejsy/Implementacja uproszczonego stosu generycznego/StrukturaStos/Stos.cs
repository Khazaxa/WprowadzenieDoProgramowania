using System;
using System.Collections.Generic;

namespace StrukturaStos
{
    public class Stos<T> : IStos<T>
    {
        private List<T> _list;

        public Stos()
        {
            _list = new List<T>();
        }

        public void Push(T value)
        {
            _list.Add(value);
        }

        public T Peek
        {
            get
            {
                if (IsEmpty) throw new StosEmptyException();
                return _list[_list.Count - 1];
            }
        }

        public T Pop()
        {
            if (IsEmpty) throw new StosEmptyException();
            T item = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return item;
        }

        public int Count
        {
            get { return _list.Count; }
        }

        public bool IsEmpty
        {
            get { return _list.Count == 0; }
        }

        public void Clear()
        {
            _list.Clear();
        }

        public T[] ToArray()
        {
            T[] array = new T[_list.Count];
            _list.CopyTo(array);
            return array;
        }
    }
}
