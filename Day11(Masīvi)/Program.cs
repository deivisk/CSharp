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
            
            int randomnumber = 0;

            int galaskaitlisAI = 0;

            if (izvele == "pats")
            {
                for(int i = 0; i < ievade.Length; i++)
                {
                    Console.WriteLine("Ievadiet skaitli");

                    int vards = Convert.ToInt32(Console.ReadLine());

                    ievade[i] = vards;

                    galaskaitlis = galaskaitlis + ievade[i];

                }
            }
            else if(izvele == "dators")
            {
                randomnumber = random.Next(10, 100);

                galaskaitlisAI = galaskaitlisAI + randomnumber;

            }
            

            for(int i = 0; i < 1; i++)
            {
                if(izvele.Contains("dators") == true)
                {
                    Console.WriteLine("Datora gala summa ir - " + galaskaitlisAI);
                }
                else
                Console.WriteLine("Jūsu gala summa - " + galaskaitlis);
            }
        }
    }
}
