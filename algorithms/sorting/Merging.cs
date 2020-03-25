using System;

namespace sorting
{
    public class Merging
    {
        public static void Merge(int[] array)
        {
            int[] aux = new int[array.Length];
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low)
                {
                    return;
                }

                int mid = (high + low) / 2;
                Sort(low, mid);
                Sort(mid+1, high);
                MergeLocal(low, mid, high);
            }
            void MergeLocal(int low, int mid, int high)
            {
                int i = low;
                int j = mid + 1;

                Array.Copy(array, low, aux, low, high - low + 1);
                
                for (int k = low; k <= high; k++)
                {
                    if (i > mid) array[k] = aux[j++];
                    else if (j > high) array[k] = aux[i++];
                    else if (aux[j] < aux[i]) array[k] = aux[j++];
                    else array[k] = aux[i++];
                }
            }

        }
    }

    public class Merging2
    {
        public void MergeSort(int[] array) {
            int[] result = MergeSort(array, 0, array.Length);
        }

        public int[] MergeSort(int[] array, int start, int end) {
            if ((end - start) < 2){
                return new int[] { array[start] };
            }

            int middle = (end - start)/2;
            int[] left = MergeSort(array, start, middle);
            int[] right = MergeSort(array, middle, end);

            int[] result = new int[left.Length + right.Length];
            int indexLeft = 0, indexRight = 0;
            int i = 0;
            for (i = 0; indexLeft < left.Length && indexRight < right.Length; i++){
                if (left[indexLeft] < right[indexRight]){
                    result[i] = left[indexLeft];
                    indexLeft++;
                } else {
                    result[i] = right[indexRight];
                    indexRight++;
                }
            }
            i=0;
            while(indexLeft < left.Length){
                result[i++] = left[indexLeft];
            }
            while(indexRight < right.Length){
                result[i++] = right[indexRight];
            }
            return result;
        }

        public void Run(){
            int[] arr = new int[] { 32, 943, 78, 956, 32, 12, 94, 7, 37, 822, 1 };

            MergeSort(arr);

            System.Console.WriteLine(string.Join(", ", arr));

        }
    }
}