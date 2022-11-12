public class Kata
{
  public static string Rgb(int r, int g, int b)
  {
    Console.WriteLine(r);
    Console.WriteLine(g);
    Console.WriteLine(b);
    
    if (r > 255) r = 255;
    if (g > 255) g = 255;
    if (b > 255) b = 255;
    
    if (r < 0) r = 0;
    if (g < 0) g = 0;
    if (b < 0) b = 0;


    string R = r.ToString("X");
    string G = g.ToString("X");
    string B = b.ToString("X");


    if (R.Length == 1) R = "0" + R;
    if (G.Length == 1) G = "0" + G;
    if (B.Length == 1) B = "0" + B;

    return R + G + B;
  }

  public static void Main()
  {
    Console.WriteLine(Rgb(212, 53, 12));
    Console.WriteLine(Rgb(255, 255, 255));
  }
}