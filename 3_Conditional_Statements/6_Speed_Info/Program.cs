﻿namespace _6_Speed_Info;

class Program
{
    static void Main(string[] args)
    {
        double speed = double.Parse(Console.ReadLine());

        if (speed > 1000)
        {
            Console.WriteLine("extremely fast");
        }
        else if (speed > 150 && speed <= 1000)
        {
            Console.WriteLine("ultra fast");
        }
        else if (speed > 50 && speed <= 150)
        {
            Console.WriteLine("fast");
        }
        else if (speed > 10 && speed <= 50)
        {
            Console.WriteLine("average");
        }
        else
        {
            Console.WriteLine("slow");
        }

    }
}
