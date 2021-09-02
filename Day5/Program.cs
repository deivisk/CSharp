using System;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {

                Random random = new Random();

                int randomnumber = random.Next(1, 11);

                int Num = NumInput();


                if (randomnumber == Num)
                {
                    Console.WriteLine("Apsveicu, tu uzminēji!");
                }
                else
                {
                    Console.WriteLine("Tu neuzminēji, īstias cipars ir " + randomnumber);
                }
            }

            int 

        }


        static int NumInput()
        {

            Console.WriteLine("Ievadi un uzmini skaitli no 1 līdz 10");

            return Convert.ToInt32(Console.ReadLine());

        }

    }
}
