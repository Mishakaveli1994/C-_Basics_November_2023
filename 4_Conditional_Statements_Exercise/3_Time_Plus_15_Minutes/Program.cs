namespace _3_Time_Plus_15_Minutes;

class Program
{
    static void Main(string[] args)
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        int totalMinutes = hours * 60 + minutes + 15;

        int futureHours = totalMinutes / 60 % 24;

        int futureMinutes = totalMinutes % 60;

        Console.WriteLine($"{futureHours}:{futureMinutes:D2}");
    }
}
