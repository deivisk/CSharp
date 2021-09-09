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

            Console.WriteLine(saraksts);

        }
        public static void ShowList()
        {
            Console.WriteLine(saraksts);
        }
    }
}
