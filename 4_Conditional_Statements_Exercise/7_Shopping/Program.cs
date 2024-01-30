namespace _7_Shopping;

class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        int gpu = int.Parse(Console.ReadLine());
        int cpu = int.Parse(Console.ReadLine());
        int ram = int.Parse(Console.ReadLine());

        double gpuPrice = gpu * 250;
        double cpuPrice = cpu * (gpuPrice * 0.35);
        double ramPrice = ram * (gpuPrice * 0.1);

        double finalPrice = gpuPrice + cpuPrice + ramPrice;

        if (gpu > cpu){
            finalPrice *= 0.85;
        }

        if (budget >= finalPrice){
            Console.WriteLine($"You have {budget - finalPrice:0.00} leva left!");
        }
        else{
            Console.WriteLine($"Not enough money! You need {finalPrice - budget:0.00} leva more!");
        }
    }
}