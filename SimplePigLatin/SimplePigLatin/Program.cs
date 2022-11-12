using System;
using System.Collections.Generic;
using System.Linq;


public class Kata
{
  public static string PigIt(string str)
  {
    List<string> words = str.Split(" ").ToList();
    string result = "";


    
    
    foreach (var word in words)
    {
      string toEnd = word == "!" ? word : word.ElementAt(0) + "ay";
      string newstr = word.Remove(0, 1);

      result += newstr + toEnd + " ";
    }

    return result.Trim();
  }

  public static void Main()
  {
    Console.WriteLine(PigIt("Pig latin is cool"));
    Console.WriteLine(PigIt("Hello world !"));
  }
}