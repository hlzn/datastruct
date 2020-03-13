namespace linearSearch
{
    public class BinarySearch
    {
        public static int IterativeBinarySearch(int[] array, int value)
        {
            int low = 0;
            int high = array.Length;

            while (low < high)
            {
                int mid = (low + high) / 2;

                if (array[mid] == value)
                {
                    return mid;
                }
                if (array[mid] < value)
                {
                    low = mid + 1;
                } else {
                    high = mid;
                }
            }
            return -1;
        }

        public static int RecursiveBinarySearch(int[] array, int value)
        {
            return InternalRecursiveBinarySearch(0, array.Length);
            int InternalRecursiveBinarySearch(int low, int high)
            {
                if (low >= high)
                {
                    return -1;
                }
                int mid = (low + high) / 2;
                if (array[mid] == value)
                {
                    return mid;
                }
                if (array[mid] < value)
                {
                    return InternalRecursiveBinarySearch(mid+1, high);
                } else {
                    return InternalRecursiveBinarySearch(low, mid);
                }
            }
        }
    }
}