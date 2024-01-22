namespace _8_Pet_Shop;

class Program
{
    static void Main(string[] args)
    {
        double dogFood = double.Parse(Console.ReadLine()) * 2.5;
        double catFood = double.Parse(Console.ReadLine()) * 4;
        Console.WriteLine($"{dogFood + catFood} lv.");
    }
}
