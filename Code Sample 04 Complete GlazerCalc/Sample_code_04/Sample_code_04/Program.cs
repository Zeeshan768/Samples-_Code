using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_code_04
{
    class GlazerCalc
    {
        static void Main(string[] args)
        {
            double width, height, woodLength, glassArea;
            const double MAX_WIDTH = 5.0;
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75;
            string widthString, heightString;
            Console.Write("Give the width of Window : ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            if (width < MIN_WIDTH)
            {
                Console.WriteLine("width is too small. \n\n");
                Console.WriteLine("Using minimum");
                width = MIN_WIDTH;
            }
            if (width > MAX_WIDTH)
            {
                Console.WriteLine("Width is too large. \n\n");
                Console.WriteLine("Using maximum");
                width = MAX_WIDTH;
            }
            Console.Write("Give the height of the window : ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            if (height < MIN_HEIGHT)
            {
                Console.WriteLine("Height is too small.\n\n");
                Console.WriteLine("Using minium");
                height = MIN_HEIGHT;
            }
            if (height > MAX_HEIGHT)
            {
                Console.WriteLine("Height is too large.\n\n");
                Console.WriteLine("Using mixium");
                height = MAX_HEIGHT;
            }
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of wood is " + woodLength + " square metres");
            Console.WriteLine("The glass area is " + glassArea + "Square meters");
            Console.ReadKey();

        }
    }
}
