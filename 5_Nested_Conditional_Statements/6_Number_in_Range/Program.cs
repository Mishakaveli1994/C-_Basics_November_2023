namespace _6_Number_in_Range;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        if (number != 0 && number >= -100 && number <= 100)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
