using System;

namespace CW {
  class UrlShortener {
    
    public string Shorten(string longURL) {
      
      
      Console.WriteLine("short");
      Console.WriteLine(longURL);
      
      return "https://short.ly/";
    }
    
    public string Redirect(string shortURL) {
      Console.WriteLine("red");
      Console.WriteLine(shortURL);
      return "la";
    }


    static public void Main()
    {
      Console.WriteLine("https://www.codewars.com/kata/5ef9c85dc41b4e000f9a645f");
    }
    
  }
}