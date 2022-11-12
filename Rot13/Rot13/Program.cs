using System;
using System.Collections.Generic;
using System.Globalization;

public class Kata
{
    static readonly string[] connectionString =
    {
        "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
        "w", "x", "y", "z"
    };

    public static string Rot13(string message)
    {
        List<string> list = new List<string>();
        foreach (var letter in message)
        {
            if (Char.IsLetter(letter) == false)
            {
                list.Add(char.ToString(letter));
                continue;
            }


            bool isUpper = letter.ToString() == letter.ToString().ToUpper();

            int indexOf = Array.IndexOf(connectionString, letter.ToString().ToLower());
            int toSeach = indexOf + 13;
            if (toSeach >= connectionString.Length)
            {
                toSeach -= connectionString.Length;
            }

            string toAdd = isUpper
                ? new string(connectionString[toSeach]).ToUpper()
                : new string(connectionString[toSeach]);

            list.Add(toAdd);
        }

        return string.Join("", list.ToArray());
    }


    static public void Main()
    {
        Console.WriteLine(string.Join("", Rot13("Grfg")));
        Console.WriteLine(string.Join("", Rot13("abcdefghijklmnopqrstuvwxyz")));
    }
}