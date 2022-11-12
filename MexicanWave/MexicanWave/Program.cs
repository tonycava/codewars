using System.Collections.Generic;

namespace Main
{
    public class Kata
    {
        static public List<string> Wave(string str)
        {
            List<string> list = new List<string>();

            char[] characters = str.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == ' ') continue;
                    characters = str.ToCharArray();
                
                string temp = characters[i].ToString().ToUpper();
                characters[i] = temp[0];
                list.Add(new string(characters));
            }

            return list;
        }

        static public void Main()
        {
            List<string> result = new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" };
            
            Console.WriteLine(string.Join("==>", result));
            Console.WriteLine(string.Join("==>", Wave("two words")));

            
            
        }
    }
}