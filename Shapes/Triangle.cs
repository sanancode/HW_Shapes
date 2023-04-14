using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6_HW_Shapes.MenuUtil;

namespace Week6_HW_Shapes.Shapes
{
    internal class Triangle : Main.Shape
    {
        public static int count;
        public Triangle(string name) : base(name)
        {
            count++;
        }
        public override void perimeter()
        {
            Console.WriteLine("\n");

            Console.Write($"Please enter the {this.Name}'s first side: ");
            float side1 = float.Parse(Console.ReadLine());

            Console.Write($"Please enter the {this.Name}'s second side: ");
            float side2 = float.Parse(Console.ReadLine());

            Console.Write($"Please enter the {this.Name}'s third side: ");
            float side3 = float.Parse(Console.ReadLine());

            float result = (float)(side1 + side2 + side3);

            Menu.sleep(5, 300);

            Console.WriteLine($"\n{this.Name}'s perimeter is: {result}");
        }

        public override void area()
        {
            Console.WriteLine("\n");

            Console.Write($"Please enter the {this.Name}'s base side: ");
            float baseside = float.Parse(Console.ReadLine());

            Console.Write($"Please enter the {this.Name}'s height side: ");
            float height = float.Parse(Console.ReadLine());

            float result = (float)((baseside * height) / 2);

            Menu.sleep(5, 300);

            Console.WriteLine($"\n{this.Name}'s area is: {result}");
        }
    }
}
