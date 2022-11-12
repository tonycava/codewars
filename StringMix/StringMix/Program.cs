using System;

namespace CSharpDiscovery.Quest03
{

  public class PointOfInterest
  {
    public double Latitude { get; set; } = 0;   
    public double Longitude { get; set; } = 0;   
    public string Name { get; set; } = "";

    public PointOfInterest()
    {
      Name = "Bordeaux Ynov Campus";
      Latitude = 44.854186;
      Longitude = -0.5663056;
    }
    
    public PointOfInterest(string name, double latitude, double longitude)
    {
      Name = name;
      Latitude = latitude;
      Longitude = longitude;
    }

    // https://www.google.com/maps/place/Bordeaux+Ynov+Campus/@44.854186,-0.5663056,15z/
    // https://www.google.com/maps/place/Bordeaux+Ynov+Campus@44.854186/@-0.5663056,15z/

    public int GetDistance(PointOfInterest other)
    {
      return 1;
    }

    public static int GetDistance(PointOfInterest p1, PointOfInterest p2)
    {
      float DeltaFi = (float)ConvertToRadians(p2.Latitude - p1.Latitude);
      float DeltaLambda = (float)ConvertToRadians(lon2 - lon1);
      float a = Mathf.Sin(DeltaFi / 2) * Mathf.Sin(DeltaFi / 2) + Math.Cos(fi1) * Mathf.Cos(fi2) * Mathf.Sin(DeltaLambda / 2) * Mathf.Sin(DeltaLambda / 2);
      float c = 2 * Mathf.Atan2(Mathf.Sqrt(a), Mathf.Sqrt(1 - a));
      float distance = earthD * c;
    }

    public string ToString()
    {
      return $"{Name} (Lat={Latitude}, Long={Longitude})";
    }
    
    public string GetGoogleMapsUrl()
    {
      return $"https://www.google.com/maps/place/{Name.Replace(' ', '+')}/@{Latitude},{Longitude},15z/";
    }
    
    
  }
  
  class Program
  {
    static void Main(string[] str)
    {
      var BordeauxCampus = new PointOfInterest();
      var ParisCampus = new PointOfInterest("Paris Ynov Campus", 48.9016552, 2.2079985);

      Console.WriteLine(BordeauxCampus.GetDistance(ParisCampus));
      Console.WriteLine(PointOfInterest.GetDistance(BordeauxCampus, ParisCampus));
    }
  }
}