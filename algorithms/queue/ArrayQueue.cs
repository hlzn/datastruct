using System;
using System.Collections;
using System.Collections.Generic;

namespace queue
{
    public class ArrayQueue<T> : IEnumerable<T>
    {
        private T[] _queue;
        private int _head;
        private int _tail;

        public int Capacity => _queue.Length;

        public int Count { 
            get {
                return  _tail - _head;
            }
        }

        public bool IsEmpty { get{
            return Count == 0;
        } set { } }

        public ArrayQueue()
        {
            const int defaulCapacity = 4;
            _queue = new T[defaulCapacity];
        }

        public ArrayQueue(int capacity)
        {
            _queue = new T[capacity];
        }

        public void Enqueue(T item)
        {
            if (_queue.Length == _tail)
            {
                T[] largeArray = new T[Count*2];
                Array.Copy(_queue, largeArray, Count);
                _queue = largeArray;
            }_queue[_tail++] = item;
        }

        public void Dequeue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            
            _queue[_head++] = default(T);

            if (IsEmpty)
            {
                _head = _tail = 0;
            }
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            return _queue[_head];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = _head; i < _tail; i++)
            {
                yield return _queue[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}