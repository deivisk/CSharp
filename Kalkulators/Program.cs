using System;

namespace Kalkulators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            int b = Convert.ToInt32(Console.ReadLine());

            string c = Console.ReadLine();

            if(c == "+")
            {
                a = a + b;
            }

            Console.WriteLine(a);
        }
    }
}
