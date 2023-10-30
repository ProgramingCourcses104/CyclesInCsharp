using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclesInCsharp.Figures
{
    internal class Triangle : Figure, IFigure
    {
        public Triangle() {
            Name = "Triangle";
        }

        public Triangle(int x, int y) : base(x, y)
        {
            Name = "Triangle";
        }

        public override void PrintFigure()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    
                    if (i >= j)
                    {
                        ArrayElements[i, j] = "#";
                    }
                    else
                    {
                        ArrayElements[i, j] = " ";


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

            Console.WriteLine($"{Name} area={((double)(Height * Width))/2}");
        }
    }
}
