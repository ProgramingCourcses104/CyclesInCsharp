using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclesInCsharp.Figures
{
    internal class Figure: IFigure
    {
        protected string Name { get; set; } = "Figure";
        public int Height { get; set; }
        public int Width { get; set; }

        public string[,] ArrayElements { get; set; }

        public Figure() { }

        public Figure(int height, int width)
        {
            Height = height;
            Width = width;
            ArrayElements = new string[Height, Width];
        }

        public virtual void SetInputSize()
        {
            Height = 0;
            Width = 0;

            string exitChar = null;
            Console.WriteLine($"{Name} :");

            while ((Height == 0 || Width == 0) && exitChar != "n")
            {
                Console.WriteLine("Write height: ");
                string heightInput = Console.ReadLine();

                if (int.TryParse(heightInput, out int heightParsed))
                {
                    Height = heightParsed;
                }
                else
                {
                    exitChar = heightInput;
                    Console.WriteLine($"input width : '{heightInput}' is not correct should be a real number");
                    continue;
                }

                Console.WriteLine("Write width: ");
                string widthInput = Console.ReadLine();

                if (int.TryParse(widthInput, out int widthParsed))
                {
                    Width = widthParsed;
                }
                else
                {
                    exitChar = widthInput;
                    Console.WriteLine($"input width : '{widthInput}' is not correct should be a real number");
                    continue;
                }
            }

            ArrayElements = new string[Height, Width];
        }

        public virtual void PrintFigure()
        {
            Console.WriteLine($"###\nPrint method from base figure class Height={Height} Width={Width}\n###");
        }

        public virtual void PrintFigureArea()
        {
            Console.WriteLine($"{Name} height={Height}, width={Width}");
        }
    }
}
