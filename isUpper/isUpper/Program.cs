// See https://aka.ms/new-console-template for more information

static bool isCap(string str)
{
    return str.ToUpper().Equals(str);
}

Console.WriteLine(isCap("LLLL"));
Console.WriteLine(isCap("LLLl"));