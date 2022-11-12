

namespace Solution
{
    public class Kata
    {
        public static List<Tuple<char, int>> OrderedCount(string input)
        {
            List<Tuple<char, int>> list = new List<Tuple<char, int>>();

            foreach (var s in input)
            {
                Tuple<char, int>[] l = list.ToArray();

                List<Tuple<char, int>> newList = new List<Tuple<char, int>>();

                foreach (var tup in l)
                {
                    if (tup.Item1 == s)
                    {
                        newList.Add(new Tuple<char, int>(tup.Item1, tup.Item2 + 1));
                    }
                    else
                    {
                        newList.Add(tup);
                    }
                }
                list.Clear();
                list.Concat(newList);
                newList.Clear();
            }

            return list;
        }

        static void Main()
        {
            Console.WriteLine(OrderedCount("abracadabra"));
        }
    }
    
}