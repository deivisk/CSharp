using System;

namespace Day13_Saraksti_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] first = new int[5];

            int[] second = new int[6];

            int randomnumber = 0;

            for(int i = 0; i < first.Length; i++)
            {
                first[i] = randomnumber = random.Next(1, 6);

                second[i] = first[i];

            }
            Console.WriteLine("Ievadiet skaitli");

            second[5] = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < second.Length; i++)
            {
                Console.WriteLine(second[i]);
            }
        }
    }
}
