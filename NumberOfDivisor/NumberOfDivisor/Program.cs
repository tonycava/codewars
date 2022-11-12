using System;
using System.Collections.Generic;


public static class Kata
{
    public static (int, int, (int, int[])) ProcArrInt(int[] numbers)
    {
        (int, int, (int, int[])) result = (0, 0, (0, new int[] { }));
        result.Item1 = numbers.Length;

        int numberOfPrime = 0;

        int acutalMaxNumberOfDivsor = 0;

        int myNumberOfDivisor = 0;

        List<int> list = new List<int>();

        foreach (var number in numbers)
        {
            if (IsPrime(number)) numberOfPrime += 1;
            
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) myNumberOfDivisor += 1;
            }

            Console.WriteLine("number : {0} / divisor : {1}", number, myNumberOfDivisor);

            if (myNumberOfDivisor > acutalMaxNumberOfDivsor)
            {
                acutalMaxNumberOfDivsor = myNumberOfDivisor;

                list.Clear();
                list.Add(number);
            }
            else if (myNumberOfDivisor == acutalMaxNumberOfDivsor) list.Add(number);

            myNumberOfDivisor = 0;
        }

        result.Item2 = numberOfPrime;
        result.Item3.Item1 = acutalMaxNumberOfDivsor;

        int[] array = list.ToArray();
        Array.Sort(array);

        result.Item3.Item2 = array;

        return result;
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int) Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }

    public static void Main()
    {
        var result = ProcArrInt(new int[]
        {
            66, 36, 49, 40, 73, 12, 77, 78, 76, 8, 50,
            20, 85, 22, 24, 68, 26, 59, 92, 93, 30
        });

        Console.WriteLine(result.Item1);
        Console.WriteLine(result.Item2);
        Console.WriteLine(result.Item3.Item1);

        Console.WriteLine(string.Join("==>", result.Item3.Item2));
    }
}