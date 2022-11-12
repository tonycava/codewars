public class ShortLongShort
{
    public static string Solution(string a, string b)
    {
        if (a.Length > b.Length)
        {
            return b + a + b;
        }
        return a + b + a;
    }
}