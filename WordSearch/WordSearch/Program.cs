using System.Text.RegularExpressions;
using System;
using System.Linq.Expressions;


namespace Main
{
    public class Kata
    {
        public static string[] WordSearch(string query, string[] seq)
        {
            List<string> result = new List<string>();

            foreach (string phrase in seq)
            {
                Regex re = new Regex(@query, RegexOptions.IgnoreCase);
                if (re.IsMatch(phrase)) result.Add(phrase);
            }


            return result.Count == 0 ? new string[] {"Empty"} : result.ToArray();
        }
    }

    public class Other
    {
        public static void Main()
        {
            Console.WriteLine(string.Join("==>", Kata.WordSearch("", new string[] {"me"})));
            Console.WriteLine(string.Join("==>", Kata.WordSearch("", new string[] {"me"})));
        }
    }
}