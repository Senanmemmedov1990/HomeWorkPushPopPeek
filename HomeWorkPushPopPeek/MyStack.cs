using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPushPopPeek
{
    public class MyStack<T> : IEnumerable
    {
        private T[] _stack;
        public int Count { get; set; }
        public int Capacity { get; set; }

        public MyStack()
        {
            Capacity = 4;
            _stack = new T[Capacity];
        }

        public MyStack(int capacity)
        {
            Capacity = capacity;
            _stack = new T[capacity];
        }

        public MyStack(ICollection c)
        {
            Capacity = c.Count;
            _stack = new T[Capacity];
        }

        public void Push(T item)
        {
            if (Capacity == Count)
            {
                Capacity *= 2;
                Array.Resize(ref _stack, Capacity);
            }
            _stack[Count] = item;
            Count++;
        }
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Errrrrrror");
            }
            return _stack[Count - 1];
        }

        public T Pop()
        {
            Count--;
            return _stack[Count];
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return _stack[i];
            }          
        }
    }
}
