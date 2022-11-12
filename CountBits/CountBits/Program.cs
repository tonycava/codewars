namespace Main
{
    public class Kata
    {
        public static int CountBits(int n)
        {
            if (n == 0) return 0;
            
            int total = 0;
            string binaryNumberString = Convert.ToString(n, 2);

            foreach (var s in binaryNumberString)
            {
                if (s == '1')
                {
                    total++;
                }
            }
            return total;
        }

        static void Main()
        {
            Console.WriteLine(CountBits(0));
            Console.WriteLine(CountBits(1234));
        }
    }
}