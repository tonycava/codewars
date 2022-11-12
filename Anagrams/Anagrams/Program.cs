using System;
using System.Collections.Generic;

public static class Kata
{
  public static List<string> Anagrams(string word, List<string> words)
  {
    Dictionary<char, int> charcaterNeeded = new Dictionary<char, int>();
    Dictionary<char, int> myCharacter = new Dictionary<char, int>();
    List<string> list = new List<string>();


    foreach (var letter in word)
    {
      if (charcaterNeeded.ContainsKey(letter)) charcaterNeeded[letter] += 1;
      else charcaterNeeded.Add(letter, 1);
    }
    int t = 12;
    string temp = t;
    
    foreach (var anagrams in words)
    {
      
      foreach (var anagram in anagrams)
      {
        if (myCharacter.ContainsKey(anagram)) myCharacter[anagram] += 1;
        else myCharacter.Add(anagram, 1);
      }
      var isAddedToList = charcaterNeeded.OrderBy(kvp => kvp.Key)
        .SequenceEqual(myCharacter.OrderBy(kvp => kvp.Key));
      
      if (isAddedToList) list.Add(anagrams);
      
      myCharacter.Clear();
    }
    return list;
  }

  static void Main()
  {
    Console.WriteLine(string.Join("==>", Anagrams("a", new List<string> {"a", "b", "c", "d"})));
    Console.WriteLine(string.Join("==>",
      Anagrams("racer",
        new List<string> {"carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr"})));
  }
}