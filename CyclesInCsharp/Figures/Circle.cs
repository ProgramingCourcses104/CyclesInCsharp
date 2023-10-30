using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclesInCsharp.Figures
{
    internal class Circle: Figure, IFigure
    {
        const double Pi = 3.14;
        public Circle() : base()
        { 
            Name = nameof(Circle);
        }

        public Circle(int diameter): base(diameter, diameter)
        {
            Name = nameof(Circle);
        }

        public override void SetInputSize()
        {

            Height = 0;
            Width = 0;

            string exitChar = null;
            Console.WriteLine($"{Name} :");

            while ((Height == 0 || Width == 0) && exitChar != "n")
            {
                Console.WriteLine("diameter: ");
                string heightInput = Console.ReadLine();

                if (int.TryParse(heightInput, out int heightParsed))
                {
                    Height = heightParsed;
                    Width = heightParsed;
                }
                else
                {
                    exitChar = heightInput;
                    Console.WriteLine($"input width : '{heightInput}' is not correct should be a real number");
                    continue;
                }
              
            }

            ArrayElements = new string[Height, Width];
        }

        public override void PrintFigureArea()
        {
           var r = (double)Height / 2;

            base.PrintFigureArea();

            Console.WriteLine($"{Name} area={Pi*r*r}");
        }

    }
}
