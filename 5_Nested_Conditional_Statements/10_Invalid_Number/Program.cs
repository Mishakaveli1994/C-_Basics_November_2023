namespace _10_Invalid_Number;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        if (num != 0 && (num > 200 || num < 100))
        {
            Console.WriteLine("invalid");
        }
    }
}
