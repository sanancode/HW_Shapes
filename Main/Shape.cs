using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_HW_Shapes.Main
{
    internal abstract class Shape
    {
        public string Name { get; set;}
        public Shape(string name)
        {
            this.Name = name;
        }

        public abstract void perimeter();
        public abstract void area();
    }
}
