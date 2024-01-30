namespace _6_World_Swimming_Record;

class Program
{
    static void Main(string[] args)
    {
        double worldRecord = double.Parse(Console.ReadLine());
        double distance = double.Parse(Console.ReadLine());
        double time = double.Parse(Console.ReadLine());

        double swim = distance * time;
        double addedTime = Math.Floor(distance / 15) * 12.5;
        double totalTime = swim + addedTime;

        if (totalTime < worldRecord){
            Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:0.00} seconds.");
        }else{
            Console.WriteLine($"No, he failed! He was {totalTime - worldRecord:0.00} seconds slower.");
        }
    }
}