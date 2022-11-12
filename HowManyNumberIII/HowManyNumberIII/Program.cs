using System;
using System.Collections.Generic;

class HowManyNumbers
{
  public static List<long> FindAll(int sumDigits, int numDigits)
  {
    List<long> list = new List<long>();
    string upTo = "";
    string startAt = "";

    for (int i = 0; i < numDigits; i++)
    {
      startAt += i == 0 ? "1" : "0";
      upTo += "9";
    }
    
    for (int i = int.Parse(startAt); i <= int.Parse(upTo); i++)
    {
      int[] iInArraySorted = i.ToString().Select(c => Convert.ToInt32(c.ToString())).ToArray();
      int[] iInArrayNoSorted = i.ToString().Select(c => Convert.ToInt32(c.ToString())).ToArray();
      Array.Sort(iInArraySorted);

      int mySum = iInArrayNoSorted.Sum();

      if (iInArraySorted.SequenceEqual(iInArrayNoSorted) && sumDigits == mySum) list.Add(i);
    }

    if (list.Count == 0) return new List<long> { };
    return new List<long> {list.Count, list.First(), list.Last()};
  }

  public static void Main()
  {
    Console.WriteLine(string.Join("==>>", FindAll(10, 3)));
    Console.WriteLine(string.Join("==>>", FindAll(27, 3)));

    Console.WriteLine(string.Join("==>>", FindAll(84, 4)));

    Console.WriteLine(string.Join("==>>", FindAll(35, 6)));
  }
}