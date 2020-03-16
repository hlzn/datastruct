namespace sorting
{
    public class QuickSorting
    {
        public static void QuickSort(int[] array)
        {
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low)
                {
                    return;
                }

                int j = Partition(low, high);
                Sort(low, j - 1);
                Sort(j + 1, high);
            }

            int Partition(int low, int high)
            {
                int i = low;
                int j = high + 1;
                int pivot = array[low];

                while (true)
                {
                    while (array[++i] < pivot)
                    {
                        if (i == high)
                        {
                            break;
                        }
                    }
                    while (pivot < array[--j])
                    {
                        if (j == low)
                        {
                            break;
                        }
                    }
                    if (i >= j)
                    {
                        break;
                    }
                    Reuse.Swap(array, i, j);
                }
                Reuse.Swap(array, low, j);
                return j;
            }
        }
    

        
    }

    public class myQuickSorting
    {
        public static void swap(int[] array, int x, int y){
            var temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }

        public static int partition(int[] array, int left, int right, int pivot){
            while(left < right){
                while(array[left] < pivot){
                    left++;
                }
                while(array[right] > pivot){
                    right--;
                }

                if (left < right){
                    swap(array, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }

        public static void myQuickSort(int[] array, int left, int right){
            if (left >=right) {
                return;
            }

            int pivot = array[(left+right)/2];
            int partitionIndex = partition(array, left, right, pivot);
            myQuickSort(array, left, partitionIndex);
            myQuickSort(array, partitionIndex+1, right);
        }

        public static void myQuickSort(int[] array)
        {
            myQuickSort(array, 0, array.Length-1);
        }
    }

    public class myQuickSorting2
    {
        private static void interchange(int[] array, int x, int y)
        {
            var temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }

        private static int middlePartition(int[] array, int left, int right, int pivot)
        {
            while(left<right){
                while(array[left] < pivot){
                    left++;
                }
                while(array[right] > pivot){
                    right--;
                }
                if (left < right){
                    interchange(array, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }

        private static void quicksort(int[] array, int left, int right)
        {
            if (left >= right){
                return;
            }
            var pivot = array[(left+right)/2];
            var middle = middlePartition(array, left, right, pivot);
            quicksort(array, left, middle);
            quicksort(array, middle+1, right);
        }
        public static void quicksort(int[] array)
        {
            quicksort(array, 0, array.Length-1);
        }
    }
}