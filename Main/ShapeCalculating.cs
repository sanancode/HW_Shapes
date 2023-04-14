using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6_HW_Shapes.MenuUtil;
using Week6_HW_Shapes.Shapes;

namespace Week6_HW_Shapes.Main
{
    internal class ShapeCalculating
    {
        //1 - perimeter / 2 - area

        public static void Triangle(int areaPer)
        {
            if (areaPer == 1)
            {
                new Triangle("Triangle").perimeter();
            }
            else
            {
                new Triangle("Triangle").area();
            }
        }
        public static void Circle(int areaPer)
        {
            if (areaPer == 1)
            {
                new Circle("Circle").perimeter();
            }
            else
            {
                new Circle("Circle").area();
            }
        }
        public static void Hexagon(int areaPer)
        {
            if (areaPer == 1)
            {
                new Hexagon("Hexagon").perimeter();
            }
            else
            {
                new Hexagon("Hexagon").area();
            }
        }
        public static void Rectangle(int areaPer)
        {
            if (areaPer == 1)
            {
                new Rectangle("Rectangle").perimeter();
            }
            else
            {
                new Rectangle("Rectangle").area();
            }
        }
        public static void Square(int areaPer)
        {
            if (areaPer == 1)
            {
                new Square("Square").perimeter();
            }
            else
            {
                new Square("Square").area();
            }
        }
    }
}
