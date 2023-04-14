using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_HW_Shapes.MenuUtil
{
    internal class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine(
                "\n1. Triangle" +
                "\n2. Circle" +
                "\n3. Hexagon" +
                "\n4. Rectangle" +
                "\n5. Square" +
                "\n6. Exit the system");
        }
        public static void menuAreaPer()
        {
            Console.WriteLine(
                "\n1. Perimeter" +
                "\n2. Area");
        }

        public static int getInteger(string title)
        {
            Console.Write(title);
            return int.Parse(Console.ReadLine());
        }

        public static void sleep(int times, int millis)
        {
            Console.Write("Wait a minute please");
            for (int i = 0; i < times; i++)
            {
                Thread.Sleep(millis);
                Console.Write(" .");
            }
        }
    }
}
