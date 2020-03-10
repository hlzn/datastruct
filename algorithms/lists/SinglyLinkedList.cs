using System;
using System.Collections;
using System.Collections.Generic;

namespace lists
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public int Count 
        {
            get;
            private set;
        }

        public bool IsEmpty
        {
            get {
                return Count == 0;
            }

            set {}
        }

        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        private void AddFirst(Node<T> node)
        {
            Node<T> tmp = Head;
            Head = node;
            Head.Next = tmp;
            Count++;

            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        private void AddLast(Node<T> node)
        {
            if (IsEmpty)
            {
                Head = node;
            } else {
                Tail.Next = node;
            }
            Tail = node;
            Count++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            Head = Head.Next;

            if (Count == 1)
            {
                Tail = null;
            }
            Count--;
        }

        public void RemoveLast()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            if (Count == 1)
            {
                Head = Tail = null;
            } else {
                var current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }
                current.Next = null;
                Tail = current;
            }
            Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}