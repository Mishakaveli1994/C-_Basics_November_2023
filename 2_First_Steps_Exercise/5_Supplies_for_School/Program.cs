namespace _5_Supplies_for_School;

class Program
{
    static void Main(string[] args)
    {
        int pens = int.Parse(Console.ReadLine());
        int markers = int.Parse(Console.ReadLine());
        int liters = int.Parse(Console.ReadLine());
        int discount = int.Parse(Console.ReadLine());

        Console.WriteLine($"{((pens * 5.8) + (markers * 7.2) + (liters * 1.2)) * ((100 - discount) / 100.0)}");
    }
}
