namespace _9_Fish_Tank;

class Program
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        double percent = double.Parse(Console.ReadLine());

        double volume = height * width * length * 0.001;
        double neededLiters = volume * (1 - percent / 100.0);

        Console.WriteLine($"{neededLiters}");
    }
}
