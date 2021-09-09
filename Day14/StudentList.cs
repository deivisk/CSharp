using System;
using System.Collections.Generic;
using System.Text;

namespace Day14
{
    class StudentList
    {
        private static List<String> saraksts = new List<String>();
        public static void AddList(string a)
        {
            saraksts.Add(a);

        }
        public static void ShowList()
        {

            Console.WriteLine("asd");
            for(int i = 0; i < saraksts.Count; i++)
            {
                Console.WriteLine(saraksts[i]);
            }

        }
    }
}
