using System.Collections.Generic;


namespace StrukturaStos
{
    public class Stos<T> : IStos<T>
    {
        private List<T> _stack = new List<T>();

        public void Push(T value)
        {
            _stack.Add(value);
        }

        public T Peek
        {
            get
            {
                if (_stack.Count == 0)
                    throw new StosEmptyException("Stos jest pusty.");

                return _stack[_stack.Count - 1];
            }
        }

        public T Pop()
        {
            if (_stack.Count == 0)
                throw new StosEmptyException("Stos jest pusty.");

            var item = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return item;
        }

        public int Count => _stack.Count;

        public bool IsEmpty => _stack.Count == 0;

        public void Clear()
        {
            _stack.Clear();
        }

        public T[] ToArray()
        {
            return _stack.ToArray();
        }


    }
}
