using System;

namespace lists
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedNode<T> Head { get; set; }
        public DoublyLinkedNode<T> Tail { get; set; }

        public bool IsEmpty { get{
            return Count == 0;
            }
            set { }
        }

        public int Count { get; set; }
        public void AddFirst(T value)
        {
            AddFirst(new DoublyLinkedNode<T>(value));
        }

        private void AddFirst(DoublyLinkedNode<T> node)
        {
            DoublyLinkedNode<T> tmp = Head;
            Head = node;
            Head.Next = tmp;
            if (IsEmpty)
            {
                Tail = Head;
            } else {
                tmp.Previous = Head;
            }
            Count++;
        }

        public void AddLast(T value)
        {
            AddLast(new DoublyLinkedNode<T>(value));
        }

        private void AddLast(DoublyLinkedNode<T> value)
        {
            if (IsEmpty)
            {
                Head = value;
            } else {
                Tail.Next = value;
                value.Previous = Tail;
            }
            Tail = value;
            Count++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            Head = Head.Next;

            Count--;
            if (IsEmpty)
            {
                Tail = null;
            } else {
                Head.Previous = null;
            }
        }

        public void RemoveLast()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            if (Count == 1)
            {
                Head = null;
                Tail = null;
            } else {
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
            }

            Count--;
        }
    }
}