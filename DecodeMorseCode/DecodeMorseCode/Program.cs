class MorseCodeDecoder
{
    public static string Decode(string morseCode)
    {
        Dictionary<string, string> morseDictionary = new Dictionary<string, string>()
        {
            {"", " "},

            {".-", "A"},
            {"-...", "B"},
            {"-.-.", "C"},
            {"-..", "D"},
            {".", "E"},
            {"..-.", "F"},
            {"--.", "G"},
            {"....", "H"},
            {"..", "I"},
            {".---", "J"},
            {"-.-", "K"},
            {".-..", "L"},
            {"-.", "N"},
            {"--", "M"},
            {"---", "O"},
            {".--.", "P"},
            {"--.-", "Q"},
            {".-.", "R"},
            {"...", "S"},
            {"-", "T"},
            {"..-", "U"},
            {"...-", "V"},
            {".--", "W"},
            {"-..-", "X"},
            {"-.--", "Y"},
            {"--..", "Z"},

            {"-----", "0"},
            {".----", "1"},
            {"..---", "2"},
            {"...--", "3"},
            {"....-", "4"},
            {".....", "5"},
            {"-....", "6"},
            {"--...", "7"},
            {"---..", "8"},
            {"----.", "9"},

            {"-.-.--", "!"},
            {".-.-.-", "."},
        };

        if (morseCode == "...---...") return "SOS";

        string output = "";
        string[] morseArray = morseCode.Contains(" ") ? morseCode.Split(" ") : new string[] {morseCode};

        string lastChar = "";

        Console.WriteLine(string.Join("==>", morseArray));


        foreach (var morse in morseArray)
        {
            if (lastChar == " ")
            {
                lastChar = "";
                continue;
            }

            output += morseDictionary[morse];
            lastChar = morseDictionary[morse].ToString();
        }

        return output;
    }


    static public void Main()
    {
        Console.WriteLine(Decode("...---..."));
    }
}