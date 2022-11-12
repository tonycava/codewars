using System;
using System.Collections.Generic;

class GapInPrimes
{
  public static long[] Gap(int g, long m, long n)
  {
    List<long> list = new List<long>();

    for (long i = m; i <= n; i++)
    {
      if (IsPrime(i)) list.Add(i);
    }


    long[] arr = list.ToArray();
    
    Console.WriteLine(string.Join("==>", arr));


    for (int i = 0; i < arr.Length - 1; i++)
    {
      if (arr[i + 1] - arr[i] == g) return new long[] {arr[i], arr[i + 1]};
    }
    return null;
  }

  public static bool IsPrime(long number)
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
  
}