using CyclesInCsharp.Figures;

namespace CyclesInCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int height = 0;
                int width = 0;

                Console.WriteLine("Write height: ");
                string heightInput = Console.ReadLine();

                if (int.TryParse(heightInput, out int heightParsed))
                {
                    height = heightParsed;
                }
                else
                {
                    Console.WriteLine($"input width : '{heightInput}' is not correct should be a real number");
                    continue;
                }

                Console.WriteLine("Write width: ");
                string widthInput = Console.ReadLine();

                if (int.TryParse(widthInput, out int widthParsed))
                {
                    width = widthParsed;
                }
                else
                {
                    Console.WriteLine($"input width : '{widthInput}' is not correct should be a real number");
                    continue;
                }

                Figure figure = new Figure(height, width);

                figure.PrintFigure();

            }

            Console.ReadKey();
        }
    }
}