namespace sorting
{
    public class Recursion
    {
        //1! = 1 * 0! = 1
        //2! = 2 * 1 = 2 * 1!
        //3! = 3 * 2 * 1 = 3 * 2!
        //4! = 4 * 3 * 2 * 1 = 4 * 3!
        //n! = n * (n - 1)!
        public static int RecurseByRecursion(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * RecurseByRecursion(n - 1);
        }

        public static int RecurseByIteration(int number)
        {
            if (number == 0)
                return 1;

            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            
            return factorial;
        }
    }
}