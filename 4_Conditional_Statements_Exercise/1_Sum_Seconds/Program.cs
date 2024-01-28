namespace _1_Sum_Seconds;

class Program
{
    static void Main(string[] args)
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        int total = first + second + third;

        int minutes = total / 60;
        int seconds = total % 60;

        Console.WriteLine($"{minutes}:{seconds:D2}");
    }
}
