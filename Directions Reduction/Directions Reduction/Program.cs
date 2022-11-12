using System;
using System.Linq;

public class DirReduction
{
  public static string[] dirReduc(string[] arr)
  {
    Dictionary<string, string> oposite = new Dictionary<string, string>
    {
      {"NORTH", "SOUTH"},
      {"SOUTH", "NORTH"},
      {"EAST", "WEST"},
      {"WEST", "EAST"},
    };

    List<string> directions = arr.ToList();

    if (directions.Count == 0) return new[] {"EAST"};
    if (arr.Distinct().Count() == arr.Length) return directions.ToArray();


    for (int i = 0; i < directions.Count; i++)
    {
      int index = directions.IndexOf(oposite[directions[i]]);
      

      if (index == -1 || index < 0) continue;

      Console.WriteLine(index - i);



        directions.RemoveAt(i);
        if (index == 0) directions.RemoveAt(index);
        else directions.RemoveAt(index - 1);
        if (directions.Count >= 3) i = 0;
    }

    if (directions.Count == 2) return new[] {directions.ElementAt(1), directions.ElementAt(0)};

    return directions.ToArray();
  }

  public static void Main()
  {
    Console.WriteLine(string.Join("==>",
      dirReduc(new string[] {"NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"})));


    Console.WriteLine(string.Join("==>",
      dirReduc(new string[] {"NORTH", "WEST", "SOUTH", "EAST"})));

    Console.WriteLine(string.Join("==>",
      dirReduc(new string[] {"NORTH","EAST","NORTH","EAST","WEST","WEST","EAST","EAST","WEST","SOUTH"})));
  }
}