class MaxSumDigits
{
    public static long[] MaxSumDig(long nmax, int maxsm)
    {
        List<int> list = new List<int>();

        for (int i = 1000; i <= nmax; i++)
        {
            int total = 0;
            int[] arr = GetIntArray(i);

            for (int j = 0; j < arr.Length; j++) total += arr[j];

            if (total > maxsm == false) list.Add(i);
        }

        int[] mylist = list.ToArray();

        long sum = 0;


        foreach (var numbers in mylist) sum += numbers;

        double average = Math.Floor((double) sum / mylist.Length);

        long nearest = mylist.OrderBy(x => Math.Abs(x - average)).First();

        return new long[] {mylist.Length, nearest, sum};
    }


    public static int[] GetIntArray(int num)
    {
        List<int> listOfInts = new List<int>();
        while (num > 0)
        {
            listOfInts.Add(num % 10);
            num /= 10;
        }

        listOfInts.Reverse();

        return listOfInts.ToArray();
    }
}