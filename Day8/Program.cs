using System;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {

            int Rem = 0;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadiet skaitli");
                int Guess = Convert.ToInt32(Console.ReadLine());

                Random random = new Random();
                int randomnumber = random.Next(1, 5);

                if(randomnumber == Guess)
                {
                    Console.WriteLine("Spēle uzvarēta!");
                    Rem++;
                }
                else
                {
                    Console.WriteLine("Spēle zaudēta");
                }

            }

            Console.WriteLine("Spēle uzvarēta " + Rem);
            Console.WriteLine("Spēle zaudēta " + (5 - Rem));        //Daudz informācijas meklēts video piemērā.

        }
    }

}   

