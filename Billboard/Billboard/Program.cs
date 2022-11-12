static double Billboard(string name, double price = 30)
{
    double total = 0;
    for (int i = 0; i < name.Length; i++) total += price;
    return total;
}