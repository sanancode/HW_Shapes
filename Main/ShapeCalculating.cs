using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6_HW_Shapes.Shapes;

namespace Week6_HW_Shapes.Main
{
    internal class ShapeCalculating
    {
        //1 - perimeter / 2 - area

        public static void Triangle(int areaPer)
        {
            if(areaPer == 1)
            {
                new Triangle().perimeter("Triangle");
            }
            else
            {
                new Triangle().area("Triangle");
            }
        }
        public static void Circle(int areaPer)
        {
            if (areaPer == 1)
            {
                new Circle().perimeter("Circle");
            }
            else
            {
                new Circle().area("Circle");
            }
        }
        public static void Hexagon(int areaPer)
        {
            if (areaPer == 1)
            {
                new Hexagon().perimeter("Hexagon");
            }
            else
            {
                new Hexagon().area("Hexagon");
            }
        }
        public static void Rectangle(int areaPer)
        {
            if (areaPer == 1)
            {
                new Rectangle().perimeter("Rectangle");
            }
            else
            {
                new Rectangle().area("Rectangle");
            }
        }
        public static void Square(int areaPer)
        {
            if (areaPer == 1)
            {
                new Square().perimeter("Square");
            }
            else
            {
                new Square().area("Square");
            }
        }
    }
}
