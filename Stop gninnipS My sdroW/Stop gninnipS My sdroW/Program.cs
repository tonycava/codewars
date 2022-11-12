using System.Collections.Generic;
using System.Linq;
using System;

namespace Main
{
    public class Kata
    {
        public static string SpinWords(string sentence)
        {
            string[] sentenceWithSpaceBreak = sentence.Split(" ");

            List<string> list = new List<string>();

            foreach (var str in sentenceWithSpaceBreak)
            {
         
                if (str.Length >= 5)
                {
                    list.Add(reversed(str));
                }
                else
                {
                    list.Add(str);
                }
            }
            return string.Join(" ", list.ToArray());
        }

        public static string reversed(string reversed)
        {
            char[] charArray = reversed.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        
        static void Main()
        {
            Console.WriteLine(SpinWords("Hey wollef sroirraw")); // "Hey fellow warriors"
        }
    }
}