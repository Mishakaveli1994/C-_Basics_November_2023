namespace _1_USD_to_BGN;

class Program
{
    static void Main(string[] args)
    {
        double usd = double.Parse(Console.ReadLine());
        Console.WriteLine($"{usd * 1.79549}");
    }
}
