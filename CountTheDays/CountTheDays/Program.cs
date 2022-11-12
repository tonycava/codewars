namespace DayCount
{
  using System;

  public class Day
  {
    public static string countDays(DateTime d)
    {
      //Have fun with coding^^

      Console.WriteLine(d.Day);

      if (d == DateTime.Now) return "Today is the day!";

      return "la";
    }


    public static void Main()
    {
      Console.WriteLine(countDays(new DateTime(2016, 12, 2)));
      Console.WriteLine(countDays(DateTime.Now));
    }
  }
}