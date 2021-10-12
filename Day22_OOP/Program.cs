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

            double avarage = (randomnum + randomnumb)/2

            Candidate first = new Candidate("Pēteris ", "Gulbis", randomnumb, randomnum, avarage);
            first.izvade();

            Console.WriteLine();

            Candidate second = new Candidate("Solvita ", "Āboltiņa", randomnumb, randomnumb, avarage);
            second.izvade();
        }
    }
}
