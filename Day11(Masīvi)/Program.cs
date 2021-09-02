using System;

namespace Day11_Masīvi_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programmas skaitļus ievadīsiet pats vai dators?");

            Random random = new Random();

            string izvele = Console.ReadLine();

            int[] ievade = new int[10];

            int galaskaitlis = 0;

            if (izvele == "pats")
            {
                for(int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Ievadiet skaitli");

                    int vards = Convert.ToInt32(Console.ReadLine());

                    ievade[i] = vards;

                }
            }
            else if(izvele == "dators")
            {
                int randomnumber = random.Next(10, 100);
            }
            

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(galaskaitlis);
            }
        }
    }
}
