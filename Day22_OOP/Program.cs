using System;

namespace Day22_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Double randomnum = random.Next(0, 11);
            Double randomnumb = random.Next(0, 11);



            Candidate first = new Candidate("Pēteris ", "Gulbis", 2007, randomnum);
            first.izvade();

            Console.WriteLine();

            Candidate second = new Candidate("Solvita ", "Āboltiņa", 2003, randomnumb);
            second.izvade();
        }
    }
}
