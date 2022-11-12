using System.Linq;

static int[] DivisibleBy(int[] numbers, int divisor)
{
    int[] list = {};

    foreach (var item in numbers)
    {
        if (item % divisor == 0)
        {
            list = list.Append(item).ToArray();
        }
    }
    return list;
}