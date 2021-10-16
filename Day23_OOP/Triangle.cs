using System;
using System.Collections.Generic;
using System.Text;

namespace Day23_OOP
{
    class Triangle
    {
        public int FirstSide
        {
            get
            {
                return FirstSide;
            }
            set
            {
                if(FirstSide + SecondSide < ThridSide)
                {
                    FirstSide = 0;
                }
                else if(FirstSide + ThridSide < SecondSide)
                {
                    FirstSide = 0;
                }
                else
                {
                    FirstSide = value;
                }
            }
        }
        public int SecondSide { get; set; }
        public int ThridSide { get; set; }

        public Triangle(int FirstSide, int SecondSide, int ThridSide)
        {
            this.FirstSide = FirstSide;
            this.SecondSide = SecondSide;
            this.ThridSide = ThridSide;
        }

        public void Izvade()
        {
            if((FirstSide + SecondSide + ThridSide) > 0)
            {
                Console.WriteLine("Jūsu trijstūris ir pareizs!");
            }
            else
            {
                Console.WriteLine("Trijustūris neeksistē");
            }

        }
    }
}
