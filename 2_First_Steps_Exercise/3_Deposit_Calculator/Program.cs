namespace _3_Deposit_Calculator;

class Program
{
    static void Main(string[] args)
    {
        double depositSum = double.Parse(Console.ReadLine());
        int months = int.Parse(Console.ReadLine());
        double interestRate = double.Parse(Console.ReadLine());
        Console.WriteLine($"{depositSum + months * ((depositSum * (interestRate / 100)) / 12)}");
    }
}
