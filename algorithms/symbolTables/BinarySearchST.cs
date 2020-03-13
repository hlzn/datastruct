using System;
using System.Collections.Generic;
using queue;

namespace symbolTables
{
    public class BinarySearchST<TKey, TValue>
    {
        private TKey[] _keys;
        private TValue[] _values;

        public int Count { get; private set; }

        private readonly IComparer<TKey> _comparer;

        public int Capacity => _keys.Length;

        private const int DefaultCapacity = 4;

        public bool IsEmpty => Count == 0;


        public BinarySearchST(int capacity, IComparer<TKey> comparer)
        {
            _keys = new TKey[capacity];
            _values = new TValue[capacity];
            _comparer = comparer ?? throw new ArgumentNullException(paramName: "Comparer cant be null");
        }

        public BinarySearchST(int capacity):this(capacity, Comparer<TKey>.Default)
        { }

        public BinarySearchST():this(DefaultCapacity)
        { }

        public int Rank(TKey key)
        {
            int low = 0;
            int high =  Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int cmp = _comparer.Compare(x:key, y:_keys[mid]);

                if (cmp < 0)
                {
                    high = mid - 1;
                } else if (cmp > 0)
                {
                    low = mid + 1;
                } else 
                {
                    return mid;
                }
            }
            return low;
        }

        public TValue GetValueOrDefault(TKey key)
        {
            if (IsEmpty)
            {
                return default(TValue);
            }

            int rank = Rank(key);
            if (rank < Count && _comparer.Compare(x:_keys[rank], y:key) == 0)
            {
                return _values[rank];
            }
            return default(TValue);
        }

        public void Add(TKey key, TValue value)
        {
            if (key==null)
            {
                throw new ArgumentNullException(paramName: "Key cant be null");
            }

            int rank = Rank(key);
            if (rank < Count && _comparer.Compare(x:_keys[rank], y: key) == 0)
            {
                _values[rank] = value;
                return;
            }
            
            if (Count == Capacity)
            {
                Resize(capacity:Capacity * 2);
            }

            for (int j = Count; j>rank; j--)
            {
                _keys[j] = _keys[j - 1];
                _values[j] = _values[j - 1];
            }
            _keys[rank] = key;
            _values[rank] = value;
            Count++;
        }

        public void Remove(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(paramName: "Key cant be null");
            }

            if (IsEmpty)
            {
                return;
            }

            int r = Rank(key);
            if (r == Count || _comparer.Compare(x:_keys[r], y:key) != 0)
            {
                return;
            }

            for (int j = r; j < Count - 1; j++)
            {
                _keys[j] = _keys[j + 1];
                _values[j] = _values[j + 1];
            }

            Count--;
            _keys[Count] = default(TKey);
            _values[Count] = default(TValue);
        }

        public bool Contains(TKey key)
        {
            int r = Rank(key);

            if ( r < Count && _comparer.Compare(x:_keys[r], y:key) == 0)
            {
                return true;
            } else 
            {
                return false;
            }
        }

        public TKey Min()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException(message: "Table is empty");
            } else {
                return _keys[0];
            }
        }

        public TKey Max()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException(message: "Table is empty");
            } else {
                return _keys[Count - 1];
            }
        }

        public void RemoveMin()
        {
            Remove(Min());
        }

        public void RemoveMax()
        {
            Remove(Max());
        }

        public TKey Select(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentException(message: "Out of range.");
            }
            return _keys[index];
        }

        public TKey Ceiling(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(paramName: "Argument to ceil is null");
            }

            int r = Rank(key);
            if ( r == Count)
            {
                return default(TKey);
            } else {
                return _keys[r];
            }
        }

        public TKey Floor(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(paramName: "Argument to floor is null");
            }

            int r = Rank(key);
            if (r < Count && _comparer.Compare(x:_keys[r], y:key) == 0)
            {
                return _keys[r];
            }
            if (r == 0)
            {
                return default(TKey);
            } else 
            {
                return _keys[r - 1];
            }
        }

        public IEnumerable<TKey> Range(TKey left, TKey right)
        {
            var q = new LinkedQueue<TKey>();
            int low = Rank(left);
            int high = Rank(right);

            for (int i = low; i < high; i++)
            {
                q.Enqueue(_keys[i]);
            }

            if (Contains(right))
            {
                q.Enqueue(_keys[Rank(right)]);
            }

            return q;
        }

        public IEnumerable<TKey> Keys()
        {
            foreach(var key in _keys)
            {
                yield return key;
            }
        }

        private void Resize(int capacity)
        {
            TKey[] keysTmp = new TKey[capacity];
            TValue[] valuesTmp = new TValue[capacity];

            for (int i = 0; i < Count; i++)
            {
                keysTmp[i] = _keys[i];
                valuesTmp[i] = _values[i];
            }

            _values = valuesTmp;
            _keys = keysTmp;
        }
    }
}