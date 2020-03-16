using System;
using System.Collections.Generic;

namespace trees
{
    public class MaxHeap<T> where T:IComparable<T>
    {
        private const int DefaultCapacity = 4;
        private T[] _heap;

        public int Count { get; private set; }

        public bool IsFull => Count == _heap.Length;

        public bool IsEmpty => Count == 0;

        public void Insert(T value)
        {
            if (IsFull)
            {
                var newHeap = new T[_heap.Length*2];
                Array.Copy(sourceArray:_heap, sourceIndex:0, destinationArray:newHeap, destinationIndex:0, _heap.Length);
                _heap = newHeap;
            }
            _heap[Count] = value;
            Swim(Count);
            Count++;
        }

        private void Swim(int indexOfSwimmingItem)
        {
            

            T newValue = _heap[indexOfSwimmingItem];
            while(indexOfSwimmingItem > 0 && IsParentLess(indexOfSwimmingItem))
            {
                _heap[indexOfSwimmingItem] = GetParent(indexOfSwimmingItem);
                indexOfSwimmingItem = ParentIndex(indexOfSwimmingItem);
            }

            bool IsParentLess(int swimmingItemIndex){
                return newValue.CompareTo(GetParent(swimmingItemIndex)) > 0;
            }

            _heap[indexOfSwimmingItem] = newValue;
        }

        private T GetParent(int index)
        {
            return _heap[ParentIndex(index)];
        }

        private int ParentIndex(int index)
        {
            return (index - 1) / 2;
        }

        public MaxHeap():this(DefaultCapacity)
        {}

        public MaxHeap(int capacity)
        {
            _heap = new T[capacity];
        }

        public IEnumerable<T> Values()
        {
            for(var i = 0; i < Count; i++)
            {
                yield return _heap[i];
            }
        }
    
        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            return _heap[0];
        }

        public T Remove()
        {
            return Remove(0);
        }

        public T Remove(int index)
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            T removedValue = _heap[index];
            _heap[index] = _heap[Count - 1];
            if (index == 0 || _heap[index].CompareTo(GetParent(index)) < 0)
            {
                Sink(index);
            } else {
                Swim(index);
            }

            Count--;
            return removedValue;
        }

        private void Sink(int sinkingItem)
        {
            int lastHeapIndex = Count - 1;
            while(sinkingItem <= lastHeapIndex)
            {
                int leftChildIndex = LeftChildIndex(sinkingItem);
                int rightChildIndex = RightChildIndex(sinkingItem);

                if (leftChildIndex > lastHeapIndex)
                {
                    break;
                }

                int childIndexToSwap = GetChildIndexToSwap(leftChildIndex, rightChildIndex);
                if (SinkingIsLessThan(childIndexToSwap))
                {
                    Exchange(sinkingItem, childIndexToSwap);
                } else {
                    break;
                }

                sinkingItem = childIndexToSwap;
            }

            bool SinkingIsLessThan(int childToSwap)
            {
                return _heap[sinkingItem].CompareTo(_heap[childToSwap]) < 0;
            }

            void Exchange(int leftIndex, int rightIndex)
            {
                T tmp = _heap[leftIndex];
                _heap[leftIndex] = _heap[rightIndex];
                _heap[rightIndex] = tmp;
            }

            int GetChildIndexToSwap(int leftChildIndex, int rightChildIndex)
            {
                int childToSwap;
                if (rightChildIndex > lastHeapIndex)
                {
                    childToSwap = leftChildIndex;
                } else {
                    int compareTo = _heap[leftChildIndex].CompareTo(_heap[rightChildIndex]);
                    childToSwap = compareTo > 0 ? leftChildIndex : rightChildIndex;
                }
                return childToSwap;
            }
        }

        private int LeftChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 1;
        }

        private int RightChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 2;
        }
    }
}