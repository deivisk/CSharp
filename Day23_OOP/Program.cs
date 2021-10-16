using System;

namespace Day23_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ievadi izmēru malai");
            int FirstSide = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi izmēru malai");
            int SecondSide = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi izmēru malai");
            int ThridSide = Convert.ToInt32(Console.ReadLine());

            Triangle Tri = new Triangle(FirstSide, SecondSide, ThridSide);

            Tri.Izvade();


        }
    }
}
