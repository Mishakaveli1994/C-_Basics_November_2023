namespace _4_Vacation_Books_List;

class Program
{
    static void Main(string[] args)
    {
        int pages = int.Parse(Console.ReadLine());
        int pagesPerHours = int.Parse(Console.ReadLine());
        int days = int.Parse(Console.ReadLine());
        Console.WriteLine($"{pages / pagesPerHours / days}");
    }
}
