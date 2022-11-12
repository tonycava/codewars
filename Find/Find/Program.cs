static int Find(int[] arr) {
    List<int> evens = new List<int>();
    List<int> odds = new List<int>();

    foreach (var item in arr)
    {
        if (item % 2 == 0)
        {
            evens.Add(item);
        } else {
            odds.Add(item);
        }
    }
    return odds.Count == 1 ? odds.First() : evens.First();
}

