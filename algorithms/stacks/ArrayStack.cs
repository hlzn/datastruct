using System;
using System.Collections;
using System.Collections.Generic;

namespace stacks
{
    public class ArrayStack<T> : IEnumerable<T>
    {
        public ArrayStack()
        {
            const int defaultCapacity = 4;
            _items = new T[defaultCapacity];
        }

        public ArrayStack(int capacity)
        {
            _items = new T[capacity];
        }

        private T[] _items;

        public bool IsEmpty { 
            get {
                return Count == 0;
            } 
            private set { } 
        }
        public int Count { get; private set; }
        private bool IsFull { 
            get{
                return _items.Length == Count;
            } 
            set {} 
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            return _items[Count-1];
        }

        public void Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            _items[--Count] = default(T);
        }

        public void Push(T item)
        {
            if (IsFull)
            {
                T[] largerArray = new T[Count * 2];
                Array.Copy(_items, largerArray, Count);
                _items = largerArray;
            }
            _items[Count++] = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    
}
