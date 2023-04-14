using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_HW_Shapes.Shapes
{
    internal class Square : Main.Shape
    {
        public override void perimeter(string shapename)
        {
            Console.WriteLine("\n");

            Console.Write($"Please enter the {shapename}'s side: ");
            float side1 = float.Parse(Console.ReadLine());

            float result = (float)(side1) * 4;

            Console.WriteLine($"{shapename}'s perimeter is: {result}");
        }

        public override void area(string shapename)
        {
            Console.WriteLine("\n");

            Console.Write($"Please enter the {shapename}'s first side: ");
            float side1 = float.Parse(Console.ReadLine());

            float result = (float)(side1) * 2;

            Console.WriteLine($"{shapename}'s area is: {result}");
        }
    }
}
