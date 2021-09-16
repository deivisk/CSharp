using System;
using System.Collections.Generic;
using System.Text;

namespace Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            Random random = new Random();

                        List<int> saraksts = new List<int>();

                        int randomnumber = 0;

                        int input = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < 30; i++)
                        {
                            randomnumber = random.Next(0, 11);

                            saraksts.Add(randomnumber);
                        }

                        for (int i = 0; i < saraksts.Count; i++)
                        {
                            Console.WriteLine(saraksts[input]);
                        }
            */


            List<int> saraksts = new List<int>();

            int ievade = 0;

            int sum = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ievadi skaitli");

                ievade = Convert.ToInt32(Console.ReadLine());

                saraksts.Add(ievade);

                sum = ievade + sum;
            }

            if (sum < 15)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(saraksts[i]);
                }
            }

            if (sum > 15)
            {
                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine(saraksts[i]);
                }
            }

        }
    }
}
