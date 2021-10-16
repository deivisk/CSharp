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
        public int SecondSide
        {
            get
            {
                return FirstSide;
            }
            set
            {
                if (FirstSide + SecondSide < ThridSide)
                {
                    SecondSide = 0;
                }
                else if (SecondSide + ThridSide < FirstSide)
                {
                    SecondSide = 0;
                }
                else
                {
                    SecondSide = value;
                }
            }
        }
        public int ThridSide
        {
            get
            {
                return ThridSide;
            }
            set
            {
                if (FirstSide + ThridSide < SecondSide)
                {
                    ThridSide = 0;
                }
                else if (SecondSide + ThridSide < FirstSide)
                {
                    ThridSide = 0;
                }
                else
                {
                    ThridSide = value;
                }
            }
        }

        public void Tri(int FirstSide, int SecondSide, int ThridSide)
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
