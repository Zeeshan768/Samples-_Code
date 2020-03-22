using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Sample_01_GlazerCalc_Progr
{
    class GlazerCalc
    {
        static void Main(string[] args)
        {
            Double width, height, woodLength, glassArea;
            String widthString, heightString;

            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of wood is " + woodLength + "feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square meters");
            Console.ReadKey();
        }
    }
}
