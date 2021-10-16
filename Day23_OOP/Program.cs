using System;

namespace Day23_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle();

            Console.WriteLine("Ievadi izmēru malai");
            tri.FirstSide = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi izmēru malai");
            tri.SecondSide = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi izmēru malai");
            tri.ThridSide = Convert.ToInt32(Console.ReadLine());

            tri.Izvade();


        }
    }
}
