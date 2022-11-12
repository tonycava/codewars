// See https://aka.ms/new-console-template for more information

static int[] MoveZeroes(int[] arr)
{
    List<int> list = new List<int>();
    List<int> onlyZero = new List<int>();
    
    foreach (var item in arr)
    {
        if (item == 0)
        {
            onlyZero.Add(item);
        }
        else
        {
            list.Add(item);
        }
    }
    return list.Concat(onlyZero).ToArray();
}

int[] myArr = {1, 2, 0, 1, 0, 1, 0, 3, 0, 1};

int[] newArr = MoveZeroes(myArr);

Console.WriteLine(String.Join("==>", newArr));