static int[] CountBy(int x, int n)
{
    List<int> list = new List<int>();
    for (int i = x; i <= n * x; i += x) list.Add(i);
    return list.ToArray();
}