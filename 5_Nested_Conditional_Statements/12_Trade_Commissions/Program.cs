namespace _12_Trade_Commissions;

class Program
{
    static void Main(string[] args)
    {
        string city = Console.ReadLine();
        double sales = double.Parse(Console.ReadLine());

        if (city == "Sofia")
        {
            if (sales > 0 && sales <= 500)
            {
                Console.WriteLine($"{sales * 0.05:0.00}");
            }
            else if (sales > 500 && sales <= 1000)
            {
                Console.WriteLine($"{sales * 0.07:0.00}");
            }
            else if (sales > 1000 && sales <= 10000)
            {
                Console.WriteLine($"{sales * 0.08:0.00}");
            }
            else if (sales > 10000)
            {
                Console.WriteLine($"{sales * 0.12:0.00}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (city == "Varna")
        {
            if (sales > 0 && sales <= 500)
            {
                Console.WriteLine($"{sales * 0.045:0.00}");
            }
            else if (sales > 500 && sales <= 1000)
            {
                Console.WriteLine($"{sales * 0.075:0.00}");
            }
            else if (sales > 1000 && sales <= 10000)
            {
                Console.WriteLine($"{sales * 0.1:0.00}");
            }
            else if (sales > 10000)
            {
                Console.WriteLine($"{sales * 0.13:0.00}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (city == "Plovdiv")
        {
            if (sales > 0 && sales <= 500)
            {
                Console.WriteLine($"{sales * 0.055:0.00}");
            }
            else if (sales > 500 && sales <= 1000)
            {
                Console.WriteLine($"{sales * 0.08:0.00}");
            }
            else if (sales > 1000 && sales <= 10000)
            {
                Console.WriteLine($"{sales * 0.12:0.00}");
            }
            else if (sales > 10000)
            {
                Console.WriteLine($"{sales * 0.145:0.00}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}
