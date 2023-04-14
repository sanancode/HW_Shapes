using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6_HW_Shapes.MenuUtil;

namespace Week6_HW_Shapes.Shapes
{
    internal class Hexagon : Main.Shape
    {
        public static int count;
        public Hexagon(string name) : base(name)
        {
            count++;
        }
        public override void perimeter()
        {
            Console.WriteLine("\n");

            Console.Write($"Please enter the {this.Name}'s side: ");
            float side = float.Parse(Console.ReadLine());

            float result = (float)(side * 6);

            Menu.sleep(5, 300);

            Console.WriteLine($"\n{this.Name}'s perimeter is: {result}");
        }

        public override void area()
        {
            Console.WriteLine("\n");

            Console.Write($"Please enter the {this.Name}'s side: ");
            float side = float.Parse(Console.ReadLine());

            float result = (float)((3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2));

            Menu.sleep(5, 300);

            Console.WriteLine($"\n{this.Name}'s area is: {result}");
        }
    }
}
