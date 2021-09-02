using System;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            string izeja = "";

            while (izeja.ToUpper() != "N")
            {
                int count = 0;

                int exit = -1;
            
                int randomnumberAI = 0;

                Random random = new Random();
            
                while(exit != 0)
                {
                    int randomnumber = 0;

                    exit = RandomNum();

                    if(randomnumberAI < 17)
                    {
                        randomnumber = random.Next(1, 11);
                    }

                    if(exit == 0)
                    {
                        break;
                    }

                    count = count + exit;

                    randomnumberAI = randomnumber + randomnumberAI;

                    Console.WriteLine("Gala skaitlis " + count + ", dīleris " + randomnumberAI);

                    if(count > 21)
                    {
                        Console.WriteLine("Uzvar dators, Tu pārsniedzi 21!");

                        break;
                        
                    }
                    else if(randomnumberAI > 21)
                    {
                        Console.WriteLine("Tu uzvarēji! Dators pārsniedza 21");

                        break;

                    }


                }

                if(randomnumberAI > 21 || count > randomnumberAI)
                {
                    Console.WriteLine("Tu uzvarēji! Pretinieka summa ir " + randomnumberAI);

                }
                else if(count > 21 || count < randomnumberAI)
                {
                    Console.WriteLine("Uzvarēja dators, tā summa ir " + randomnumberAI);

                }
                else
                {
                    Console.WriteLine("Neizšķirts");

                }

                Console.WriteLine("Vai vēlaties spēlēt vēlreiz? 'Y' vai 'N'");

                izeja = Console.ReadLine();

            }

            
        }
        static int RandomNum()
        {
            Console.WriteLine("Lai sāktu spēli spied 'Y'");

            String Ievade = Console.ReadLine();


            if (Ievade.ToUpper() == "Y")
            {
                Random random = new Random();

                int randomnumber = random.Next(1, 11);

                Console.WriteLine(randomnumber);

                return randomnumber;
            }
            
            else
            {
                return 0;
            }

        }

    }
}
