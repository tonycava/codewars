using System;

public class Kata
{
  public static string Factorial(int nb)
  {
    if (nb == 0) return 1.ToString();

    double result = 1;

    for (int i = 1; i <= nb; i++)
    {
      result = i * result;
    }


    string resultString = result.ToString("F1");
    return resultString.Remove(resultString.Length - 1).Remove(resultString.Length - 2);
  }

  public static int Fact(int f)
  {
    if (f == 1) return 1;


    return f * Fact(f - 1);
  }

  public static void Main()
  {
    Console.WriteLine(Factorial(15));
    Console.WriteLine(Factorial(100));
  }
}