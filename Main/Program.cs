using Week6_HW_Shapes.MenuUtil;
using Week6_HW_Shapes.Shapes;

namespace Week6_HW_Shapes.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to the Shape Area and Perimeter Calculating System\n");

            mainMenuProccess();

            howManyProccessDone();

            Console.WriteLine("\n\tProgram ended...");
        }

        public static void mainMenuProccess()
        {
            int menu = 0;
            bool flag = true;

            do
            {
                Menu.MainMenu();
                menu = Menu.getInteger("Please select the menu above: ");

                if (menu < 7)
                {
                    if (menu != 6)
                    {
                        secondMenuProccess(menu);
                    }
                    else
                    {
                        flag = false;
                        Console.WriteLine("\nExiting the system...");
                    }
                }
                else
                {
                    Console.WriteLine("\nPlease select the menu number 1 and 6...Try again please");
                }
            } while (flag);
        }

        public static void secondMenuProccess(int menu)
        {
            int areaPer = 0;
            bool flag = true;

            Menu.menuAreaPer();
            areaPer = Menu.getInteger("Please select the menu above: ");

            do
            {
                if (areaPer <= 2 && areaPer > 0 && menu <= 6 && menu > 0)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Please select the menu number 1 and 2...Try again please");
                }
            } while (flag);

            switch (menu)
            {
                case 1:
                    ShapeCalculating.Triangle(areaPer);
                    break;
                case 2:
                    ShapeCalculating.Circle(areaPer);
                    break;
                case 3:
                    ShapeCalculating.Hexagon(areaPer);
                    break;
                case 4:
                    ShapeCalculating.Rectangle(areaPer);
                    break;
                case 5:
                    ShapeCalculating.Square(areaPer);
                    break;
            }
        }

        public static void howManyProccessDone()
        {
            Console.WriteLine("\nHow many proccesses done?" +
                $"\nCircle: {Circle.count} times" +
                $"\nHexagon: {Hexagon.count}" +
                $"\nRectangle: {Rectangle.count} times" +
                $"\nSquare: {Square.count} times" +
                $"\nTriangle: {Triangle.count} times");
        }

    }
}