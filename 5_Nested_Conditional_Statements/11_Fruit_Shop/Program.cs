namespace _11_Fruit_Shop;

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, double>> itemsDict = new Dictionary<
            string,
            Dictionary<string, double>
        >
        {
            {
                "weekDay",
                new Dictionary<string, double>
                {
                    { "banana", 2.5 },
                    { "apple", 1.2 },
                    { "orange", 0.85 },
                    { "grapefruit", 1.45 },
                    { "kiwi", 2.7 },
                    { "pineapple", 5.5 },
                    { "grapes", 3.85 }
                }
            },
            {
                "weekend",
                new Dictionary<string, double>
                {
                    { "banana", 2.7 },
                    { "apple", 1.25 },
                    { "orange", 0.9 },
                    { "grapefruit", 1.6 },
                    { "kiwi", 3 },
                    { "pineapple", 5.6 },
                    { "grapes", 4.2 }
                }
            }
        };

        string fruit = Console.ReadLine();
        string day = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        string dayType;

        switch (day)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":
                dayType = "weekDay";
                break;

            case "Saturday":
            case "Sunday":
                dayType = "weekend";
                break;

            default:
                dayType = "error";
                break;
        }

        if (itemsDict.ContainsKey(dayType) && itemsDict[dayType].ContainsKey(fruit))
        {
            double value = itemsDict[dayType][fruit];
            Console.WriteLine($"{quantity * value:0.00}");
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}
