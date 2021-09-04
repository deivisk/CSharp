using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_Saraksti_
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi studentu skaitu");

            int count = Convert.ToInt32(Console.ReadLine());

            List<String> StudentCount = new List<String>();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Ievadi studentu vardus");

                StudentCount.Add(Console.ReadLine());

            }

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(StudentCount[i]);
            }

        }
    }
}
