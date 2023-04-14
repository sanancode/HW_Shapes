using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_HW_Shapes.Shapes
{
    internal class Hexagon : Main.Shape
    {
        public override void perimeter(string shapename)
        {
            Console.WriteLine("\n");

            Console.Write($"Please enter the {shapename}'s side: ");
            float side = float.Parse(Console.ReadLine());

            float result = (float)(side * 6);

            Console.WriteLine($"{shapename}'s perimeter is: {result}");
        }

        public override void area(string shapename)
        {
            Console.WriteLine("\n");

            Console.Write($"Please enter the {shapename}'s side: ");
            float side = float.Parse(Console.ReadLine());

            float result = (float)((3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2));

            Console.WriteLine($"{shapename}'s area is: {result}");
        }
    }
}
