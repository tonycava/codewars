using System.Collections.Generic;
using System;

public class Deadfish
{
  public static int[] Parse(string data)
  {
    int total = 0;

    List<int> list = new List<int>();


    foreach (var letter in data)
    {
      if (letter == 'i') total += 1;
      if (letter == 'd') total -= 1;
      if (letter == 's') total *= total;
      if (letter == 'o') list.Add(total);
    }

    return list.ToArray();
  }


  public static void Main()
  {
    Console.WriteLine("iiisdoso");
    Console.WriteLine("iiisdosodddddiso");
  }
}