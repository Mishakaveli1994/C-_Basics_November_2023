namespace _7_Food_Delivery;

class Program
{
    static void Main(string[] args)
    {
        int chickenMenus = int.Parse(Console.ReadLine());
        int fishMenus = int.Parse(Console.ReadLine());
        int vegetarianMenus = int.Parse(Console.ReadLine());

        double totalPrice = chickenMenus * 10.35 + fishMenus * 12.4 + vegetarianMenus * 8.15;

        double desserts = totalPrice * 0.2;
        Console.WriteLine($"{totalPrice + desserts + 2.5}");
    }
}
