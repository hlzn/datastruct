namespace sorting
{
    public class Shelling
    {
        public static void Shell(int[] array)
        {
            int gap = 1;
            while (gap < array.Length/3)
            {
                gap = 3 * gap + 1;
            }

            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    for (int j = i; j >= gap && array[j] < array[j - gap]; j -= gap)
                    {
                        Reuse.Swap(array, j, j - gap);
                    }
                }
                gap /= 3;
            }
        }
    }
}