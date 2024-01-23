namespace _7_Area_of_Figures;

class Program
{
    static void Main(string[] args)
    {
        string figure = Console.ReadLine();
        if (figure == "square")
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine($"{side * side:0.000}");
        }
        else if (figure == "rectangle")
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{side1 * side2:0.000}");
        }
        else if (figure == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.Pow(radius, 2) * Math.PI:0.000}");
        }
        else if (figure == "triangle")
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(side1 * side2) / 2:0.000}");
        }

    }
}
