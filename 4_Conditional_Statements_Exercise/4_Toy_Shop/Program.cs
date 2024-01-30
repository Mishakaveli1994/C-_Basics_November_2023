namespace _4_Toy_Shop;

class Program
{
    static void Main(string[] args)
    {
        double vacation = double.Parse(Console.ReadLine());
        int puzzles = int.Parse(Console.ReadLine());
        int talkingDolls = int.Parse(Console.ReadLine());
        int bear = int.Parse(Console.ReadLine());
        int minion = int.Parse(Console.ReadLine());
        int truck = int.Parse(Console.ReadLine());

        double puzzles_price = puzzles * 2.6;
        double talkingDolls_price = talkingDolls * 3;
        double bear_price = bear * 4.1;
        double minion_price = minion * 8.2;
        double truck_price = truck * 2;

        double total_price = puzzles_price + talkingDolls_price + bear_price + minion_price + truck_price;

        if (puzzles + talkingDolls + bear + minion + truck >= 50)
        {
            total_price *= 0.75;
        }

        total_price *= 0.9;

        if (total_price >= vacation){
            Console.WriteLine($"Yes! {total_price - vacation:0.00} lv left.");
        }
        else{
            Console.WriteLine($"Not enough money! {vacation - total_price:0.00} lv needed.");
        }
    }
}
