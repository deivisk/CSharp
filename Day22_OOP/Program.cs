using System;

namespace Day22_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            double randomnum = random.Next(0, 11);
            double randomnumb = random.Next(0, 11);

            Candidate first = new Candidate("Pults ", "Grāmata", 2007, randomnum);
            first.izvade();

            Console.WriteLine();

            Candidate second = new Candidate("Spilvens ", "Krēsls", 2003, randomnumb);
            second.izvade();
        }
    }
}
