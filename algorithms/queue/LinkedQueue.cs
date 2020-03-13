using System;
using System.Collections;
using System.Collections.Generic;
using lists;

namespace queue
{
    public class LinkedQueue<T> : IEnumerable<T>
    {
        
        private readonly SinglyLinkedList<T> _list = new SinglyLinkedList<T>();

        public int Count { get { return _list.Count; } set { } }
        public bool IsEmpty { get { return Count == 0; } set { } }

        public void Enqueue(T item)
        {
            _list.AddLast(item);
        }

        public void Dequeue()
        {
            _list.RemoveFirst();
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            return _list.Head.Value;
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