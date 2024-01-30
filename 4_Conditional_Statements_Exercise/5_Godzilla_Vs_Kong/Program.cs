namespace _5_Godzilla_Vs_Kong;

class Program
{
    static void Main(string[] args)
    {
        double filmBudget = double.Parse(Console.ReadLine());
        int statistCount = int.Parse(Console.ReadLine());
        double statistClothesPrice = double.Parse(Console.ReadLine());
        double statistPrice = statistCount * statistClothesPrice;
        double decor = filmBudget * 0.1;

        if (statistCount > 150){
            statistPrice *= 0.9;
        }

        if (filmBudget - statistPrice - decor >= 0){
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {filmBudget - statistPrice - decor:0.00} leva left.");
        }else{
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {statistPrice + decor - filmBudget:0.00} leva more.");
        }

    }
}