namespace Solution
{
    public static class Program
    {
        public static int findSum(int n)
        {
            int total = 0;
            
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) total = total + i;
            }
            return total;
        }

        public static void Main()
        {
            Console.WriteLine(findSum(5));
            Console.WriteLine(findSum(10));
        }
    }
}