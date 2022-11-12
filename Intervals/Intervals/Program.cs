using System;
using Interval = System.ValueTuple<int, int>;
using System.Collections.Generic;

namespace Main
{
  static public class Intervals
  {
    public static int SumIntervals((int, int)[] intervals)
    {
      List<int> alredyPass = new List<int>();

      foreach (var interval in intervals)
      {
        for (int i = interval.Item1; i < interval.Item2; i++)
        {
          if (alredyPass.IndexOf(i) == -1) alredyPass.Add(i);

        }
      }

      return alredyPass.ToArray().Length;
    }

    static public void Main()
    {
      var watch = new System.Diagnostics.Stopwatch();

      watch.Start();

      Console.WriteLine(SumIntervals(new Interval[] { }));
      Console.WriteLine(SumIntervals(new Interval[] {(4, 4), (6, 6), (8, 8)}));

      Console.WriteLine("======================================");

      Console.WriteLine(SumIntervals(new Interval[] {(1, 2), (6, 10), (11, 15)}));
      Console.WriteLine(SumIntervals(new Interval[] {(4, 8), (9, 10), (15, 21)}));
      Console.WriteLine(SumIntervals(new Interval[] {(-1, 4), (-5, -3)}));
      Console.WriteLine(SumIntervals(new Interval[] {(-245, -218), (-194, -179), (-155, -119)}));

      Console.WriteLine("======================================");

      Console.WriteLine(SumIntervals(new Interval[] {(1, 2), (2, 6), (6, 55)}));
      Console.WriteLine(SumIntervals(new Interval[] {(-2, -1), (-1, 0), (0, 21)}));

      Console.WriteLine("======================================");

      Console.WriteLine(SumIntervals(new Interval[] {(1, 4), (7, 10), (3, 5)}));
      Console.WriteLine(SumIntervals(new Interval[] {(5, 8), (3, 6), (1, 2)}));
      Console.WriteLine(SumIntervals(new Interval[] {(1, 5), (10, 20), (1, 6), (16, 19), (5, 11)}));

      Console.WriteLine("======================================");

      Console.WriteLine(SumIntervals(new Interval[] {(2, 5), (-1, 2), (-40, -35), (6, 8)}));
      Console.WriteLine(SumIntervals(new Interval[] {(-7, 8), (-2, 10), (5, 15), (2000, 3150), (-5400, -5338)}));
      Console.WriteLine(SumIntervals(new Interval[] {(-101, 24), (-35, 27), (27, 53), (-105, 20), (-36, 26)}));

      Console.WriteLine(SumIntervals(new Interval[]
      {
        (571, 4921), (-7625, -1130), (-7045, 3152), (-8389, -6358), (-4394, 2739), (8031, 8480), (3773, 4097),
        (-4132, 5023), (2365, 3899), (2957, 4727), (-9337, -2498), (-9613, -4146), (-3773, 6766), (-9236, 7560),
        (-2969, 7190), (-287, 2126)
      }));

      watch.Stop();

      Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }
  }
}