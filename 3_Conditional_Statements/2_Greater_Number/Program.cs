namespace _2_Greater_Number;

class Program
{
    static void Main(string[] args)
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine(Math.Max(number1, number2));
    }
}
