namespace _5_Small_Shops;

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string item = Console.ReadLine();
        string city = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        Dictionary<string, Dictionary<string, double>> itemsDict = new Dictionary<
            string,
            Dictionary<string, double>
        >
        {
            {
                "Sofia",
                new Dictionary<string, double>
                {
                    { "coffee", 0.5 },
                    { "water", 0.8 },
                    { "beer", 1.2 },
                    { "sweets", 1.45 },
                    { "peanuts", 1.6 }
                }
            },
            {
                "Plovdiv",
                new Dictionary<string, double>
                {
                    { "coffee", 0.4 },
                    { "water", 0.7 },
                    { "beer", 1.15 },
                    { "sweets", 1.3 },
                    { "peanuts", 1.5 }
                }
            },
            {
                "Varna",
                new Dictionary<string, double>
                {
                    { "coffee", 0.45 },
                    { "water", 0.7 },
                    { "beer", 1.1 },
                    { "sweets", 1.35 },
                    { "peanuts", 1.55 }
                }
            }
        };

        if (itemsDict.ContainsKey(city) && itemsDict[city].ContainsKey(item))
        {
            double value = itemsDict[city][item];
            Console.WriteLine($"{quantity * value}");
        }
        else
        {
            Console.WriteLine("The specified key does not exist.");
        }
    }
}
