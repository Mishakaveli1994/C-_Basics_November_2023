namespace _8_Basketball_Equipment;

class Program
{
    static void Main(string[] args)
    {
        int basketballTax = int.Parse(Console.ReadLine());
        double shoes = basketballTax * 0.6;
        double clothes = shoes * 0.8;
        double ball = clothes * 0.25;
        double accessories = ball * 0.2;

        Console.WriteLine($"{basketballTax + shoes + clothes + ball + accessories}");
    }
}
