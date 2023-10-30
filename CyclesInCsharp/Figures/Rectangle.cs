using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclesInCsharp.Figures
{
    internal class Rectangle : Figure, IFigure
    {
        public Rectangle() : base() 
        {
            Name = "Rectangle";

        }

        public Rectangle (int height, int width) : base (height, width)
        {
            Name = "Rectangle";
        }


        public override void PrintFigure()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    int sumIndex = i + j;
                    if (sumIndex % 2 == 0)
                    {
                        ArrayElements[i, j] = "#";
                    }
                    else
                    {
                        ArrayElements[i, j] = "@";


                    }
                }
            }


            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(ArrayElements[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public override void PrintFigureArea()
        {
            base.PrintFigureArea();
            Console.WriteLine($"{Name} area={Height*Width}");
        }
    }
}
