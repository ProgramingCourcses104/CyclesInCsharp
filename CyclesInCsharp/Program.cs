using CyclesInCsharp.Figures;

namespace CyclesInCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IFigure> figures = new List<IFigure>() { new Triangle(), new Rectangle(), new Circle() };
            

            foreach(var item in figures)
            {
                item.SetInputSize();
            }

            foreach (var item in figures)
            {
                item.PrintFigure();
            }

            foreach (var item in figures)
            {
                item.PrintFigureArea();
            }


            Console.ReadKey();
        }
    }
}