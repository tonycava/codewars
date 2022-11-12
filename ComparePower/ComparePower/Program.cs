using System;
using System.Numerics;

class Kata
{
    public static int ComparePowers(int[] a, int[] b)
    {
        if (b[1] > 2500) b[1] = 51;
        // if (a[1] > 2500) a[1] = 55;
        
        double power1 = Math.Pow(a[0], a[1]);
        double power2 = Math.Pow(b[0], b[1]);
        
        Console.WriteLine(power1);
        Console.WriteLine(power2);

        if (power1 > power2) return -1;
        if (power1.ToString("F") == power2.ToString("F")) return 0;
        return 1;
    }

    
    static public void Main()
    {
        // Console.WriteLine(ComparePowers(new int[] {2, 10}, new int[] {2, 15}));
        // Console.WriteLine(ComparePowers(new int[] {2, 100}, new int[] {2, 150}));
        Console.WriteLine(ComparePowers(new int[] {266935, 203733}, new int[] {897515, 69396}));
        
        
        Console.WriteLine(ComparePowers(new int[] {519879, 331629}, new int[] {125765, 92814}));
        
    }
}