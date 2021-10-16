using System;
using System.Collections.Generic;
using System.Text;

namespace Day23_OOP
{
    class Triangle
    {
        private int _FirstSide;
        public int FirstSide
        {
            get
            {
                return _FirstSide;
            }
            set
            {
                if(value + SecondSide < ThridSide)
                {
                    _FirstSide = 0;
                }
                else if(value + ThridSide < SecondSide)
                {
                    _FirstSide = 0;
                }
                else
                {
                    _FirstSide = value;
                }
            }
        }
        private int _SecondSide;
        public int SecondSide
        {
            get
            {
                return _SecondSide;
            }
            set
            {
                if (value + FirstSide < ThridSide)
                {
                    _SecondSide = 0;
                }
                else if (value + ThridSide < FirstSide)
                {
                    _SecondSide = 0;
                }
                else
                {
                    _SecondSide = value;
                }
            }
        }
        private int _ThridSide;
        public int ThridSide
        {
            get
            {
                return _ThridSide;
            }
            set
            {
                if (value + FirstSide < SecondSide)
                {
                    _ThridSide = 0;
                }
                else if (value + SecondSide < FirstSide)
                {
                    _ThridSide = 0;
                }
                else
                {
                    _ThridSide = value;
                }
            }
        }

        public Triangle(int FirstSide, int SecondSide, int ThridSide)
        {
            this.FirstSide = FirstSide;
            this.SecondSide = SecondSide;
            this.ThridSide = ThridSide;
        }

        public void Izvade()
        {
            int perimetrs = FirstSide + SecondSide + ThridSide;

            if(perimetrs > 0)
            {
                Console.WriteLine("Jūsu trijstūris ir pareizs! Trijstūra perimetrs - " + perimetrs);
            }
            else
            {
                Console.WriteLine("Trijustūris neeksistē");
            }
        }
    }
}
