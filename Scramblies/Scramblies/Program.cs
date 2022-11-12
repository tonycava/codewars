using System;
using System.Collections.Generic;


public class Scramblies
{
  public static bool Scramble(string str1, string str2)
  {
    if (str1 == str2) return true;

    bool result = true;

    Dictionary<char, int> charcaterNeeded = new Dictionary<char, int>();

    Dictionary<char, int> myCharacter = new Dictionary<char, int>();

    foreach (var letter in str1)
    {
      if (charcaterNeeded.ContainsKey(letter)) charcaterNeeded[letter] += 1;
      else charcaterNeeded.Add(letter, 1);
    }

    foreach (var letter in str2)
    {
      if (myCharacter.ContainsKey(letter)) myCharacter[letter] += 1;
      else myCharacter.Add(letter, 1);
    }

    foreach (var item in myCharacter)
    {
      if (charcaterNeeded.ContainsKey(item.Key) == false) return false;


      if (charcaterNeeded[item.Key] >= myCharacter[item.Key]) continue;
      else return false;
    }

    return result;
  }


  static public void Main()
  {
    Console.WriteLine(Scramble("rkqodlw", "world")); // true
    Console.WriteLine(Scramble("cedewaraaossoqqyt", "codewars")); // true

    Console.WriteLine("===================================");

    Console.WriteLine(Scramble("katas", "steak")); // false
    Console.WriteLine(Scramble("scriptjavx", "javascript")); // false

    Console.WriteLine("===================================");

    Console.WriteLine(Scramble("scriptingjava", "javascript")); // true
    Console.WriteLine(Scramble("scriptsjava", "javascripts")); // true

    Console.WriteLine("===================================");

    Console.WriteLine(Scramble("javscripts", "javascript")); // false
    Console.WriteLine(Scramble("aabbcamaomsccdd", "commas")); // true

    Console.WriteLine("===================================");

    Console.WriteLine(Scramble("commas", "commas")); // true
    Console.WriteLine(Scramble("sammoc", "commas")); // true
  }
}