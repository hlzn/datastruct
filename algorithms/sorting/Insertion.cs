namespace sorting
{
    public class Insertion
    {
        public static void Insert(int[] array)
        {
            for (int wallLimit = 1; wallLimit < array.Length; wallLimit++)
            {
                int currentUnsorted = array[wallLimit];
                int i = 0;
                for(i = wallLimit; i > 0 && array[i - 1] > currentUnsorted; i--)
                {
                    array[i] = array[i - 1];
                }

                array[i] = currentUnsorted;
            }
        }
    }
}