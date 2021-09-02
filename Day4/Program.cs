using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            int All = Convert.ToInt32(Numbers(4, 77));
            Console.WriteLine("Lielākais skaitlis ir " + All);

        }
        static int Numbers(int a, int b)
        {
            if (a > b)
            {

                return a;
            }
            else if (a < b)
            {

                return b;
            }


        }
    }
}
