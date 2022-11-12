namespace Main
{
    class Quark
    {
        public string Color;
        public string Flavor;
        public int BaryonNumber;

        public Quark(string color, string flavor)
        {
            // if (color != "red" || color != "blue" || color != "green") throw new Exception();
            //
            // if (flavor != "up" || flavor != "down" || flavor != "strange" || flavor != "charm" || flavor != "top" ||
            //     flavor != "bottom") throw new Exception();


            Color = color;
            Flavor = flavor;
            BaryonNumber = 1 / 3;
        }

        public void Interact(Quark q)
        {
            (q.Color, Color) = (Color, q.Color);
        }
        
        
        static void Main()
        {
            Quark q1 = new Quark("red", "up");
            Quark q2 = new Quark("blue", "strange");
            
            Console.WriteLine(q1.Color);
            Console.WriteLine(q1.Flavor);
            
        }
    }
}