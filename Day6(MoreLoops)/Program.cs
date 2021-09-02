using System;

namespace Day6_MoreLoops_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ievadiet skaitli");

            //int Num = Convert.ToInt32(Console.ReadLine());


            //for (int i = 0; i < Num; i++) 
            //{
            //    Num = Num * Num;
            //    Console.WriteLine((Num));
            //

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadi skaitli");

                Ievade();

                Console.WriteLine(Ievade());



            }



            static int Ievade()
            {

                int Num = Convert.ToInt32(Console.ReadLine());

                return Num;
            }
        }
        
    }   
}
