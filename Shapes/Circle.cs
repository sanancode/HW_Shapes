using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6_HW_Shapes.MenuUtil;

namespace Week6_HW_Shapes.Shapes
{
    internal class Circle : Main.Shape
    {
        public static int count;
        public Circle(string name) : base(name)
        {
            count++;
        }

        public override void perimeter()
        {
            Console.WriteLine("\n");

            Console.Write($"Please enter the {this.Name}'s radius: ");
            float radius = float.Parse(Console.ReadLine());

            float result = (float)(Math.PI * radius * 2);

            Menu.sleep(5, 300);

            Console.WriteLine($"\n{this.Name}'s perimeter is: {result}");
        }

        public override void area()
        {
            Console.WriteLine("\n");

            Console.Write($"Please enter the {this.Name}'s radius: ");
            float radius = float.Parse(Console.ReadLine());

            float result = (float)(Math.PI * radius * radius);

            Menu.sleep(5, 300);

            Console.WriteLine($"\n{this.Name}'s area is: {result}");
        }
    }
}
