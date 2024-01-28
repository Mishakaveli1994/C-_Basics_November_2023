namespace _6_Repainting;

class Program
{
    static void Main(string[] args)
    {
        int nylon = int.Parse(Console.ReadLine());
        int paint = int.Parse(Console.ReadLine());
        int dissolver = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        double materials = ((nylon + 2) * 1.5) + ((paint + paint * 0.1) * 14.5) + (dissolver * 5) + 0.4;
        Console.WriteLine($"{materials + (materials * 0.3 * 8)}");
    }
}
