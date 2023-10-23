using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclesInCsharp.Figures
{
    internal class Figure: IFigure
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Figure() { }

        public Figure(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public virtual void SetInputSize() {
        
        }

        public virtual void PrintFigure()
        {
            Console.WriteLine($"###\nPrint method from base figure class Height={Height} Width={Width}\n###");
        }

    }
}
