using System;
using System.Collections;
using System.Collections.Generic;
using lists;

namespace stacks
{
    public class LinkedArrayStack<T> : IEnumerable<T>
    {
        private readonly SinglyLinkedList<T> _list = new SinglyLinkedList<T>();
        public bool IsEmpty { 
            get {
                return Count == 0;
            } 
            internal set { } 
        }
        public int Count { get; private set; }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            return _list.Head.Value;
        }

        public void Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            _list.RemoveFirst();
        }

        internal void Push(T item)
        {
            _list.AddFirst(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
