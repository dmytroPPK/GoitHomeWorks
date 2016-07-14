using System;

namespace Goit.TerraSoft.HomeWork
{
    public delegate double CircleSquare(double r);
    public delegate double BallSpace(double r);
    public delegate double RectangleSquare(double w,double h);
    public delegate double ParallelepipedSpace(double x, double y, double z);
    
    class Lesson2
    {
        public static void Run()
        {
            Console.WriteLine("Перше завдання:\n\n");
            Part2();
            Console.Write("Press any key to see next part");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Друге завдання: \n");
            Part3();
            Console.WriteLine("see you soon )\n");

        }
        private static void Part2()
        {
            CircleSquare circle = delegate(double radius ) { return Math.PI * Math.Pow(radius, 2) / 2D; };
            BallSpace ball = delegate (double radius) { return 4 / 3D * Math.PI * Math.Pow(radius, 3); };
            RectangleSquare rectangle = delegate (double width, double hight) { return width * hight; };
            ParallelepipedSpace piped = delegate (double x, double y, double z) { return x * y * z; };

            //circle
            {
                Console.Write("Please, enter the radius of circle: ");
                string radius = Console.ReadLine();
                Console.WriteLine("\tSquare: " + circle.Invoke(Double.Parse(radius))+ "\n");
            }
            //ball
            {
                Console.Write("Please, enter the radius of ball: ");
                string radius = Console.ReadLine();
                Console.WriteLine("\tSpace: " + ball.Invoke(Double.Parse(radius))+ "\n");
            }
            //rectangle
            {
                Console.Write("Please, enter the width of rectangle: ");
                string width = Console.ReadLine();
                Console.Write("Please, enter the hight of rectangle: ");
                string hight = Console.ReadLine();
                Console.WriteLine("\tSquare: " + rectangle.Invoke(Double.Parse(width),Double.Parse(hight))+ "\n");
            }
            //paralelepiped
            {
                Console.Write("Please, enter the width of paralelepiped: ");
                string width = Console.ReadLine();
                Console.Write("Please, enter the hight of paralelepiped: ");
                string hight = Console.ReadLine();
                Console.Write("Please, enter the deep of paralelepiped: ");
                string deep = Console.ReadLine();
                Console.WriteLine("\tSpace: " + piped.Invoke(Double.Parse(width), Double.Parse(hight),Double.Parse(deep)) + "\n");
            }

        }
        private static void Part3()
        {
            int x = 5, y = 12, z = 2;
            int result = (x++ - --y + --x << z++) * (x + y + z);
            Console.WriteLine("x = 5, y = 12, z = 2\n"+ "Result of: (x++ - --y + --x << z++) * (x + y + z)\n \t= "+result);
            string answer = "Solution:\n\tStep 1: (6 - 11 + 4 << 2) * (5 + 12 + 2)\n\tStep 2: (-1 << 2)*(19)\n\tStep 3: -4 * 19 = -76\n";
            Console.WriteLine(answer);
        }
    }
}
