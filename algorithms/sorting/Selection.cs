namespace sorting
{
    public class Selection
    {
        public static void Select(int[] array)
        {
            for (int wallPosition = array.Length - 1; wallPosition > 0; wallPosition--)
            {
                int largest = 0;
                for (int i = 0; i <= wallPosition; i++)
                {
                    if (array[i] > array[largest])
                    {
                        largest = i;
                    }
                }
                Swap(array, largest, wallPosition);
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
            {
                return;
            }

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}