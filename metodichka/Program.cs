using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodichka
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(0, 0, 3);
            c.Colour = "Purple";
            c.Visual = false;
            Console.WriteLine("Circle: ");
            c.Display();
            Console.WriteLine($"Площадь круга: {c.GetSquare()}");
            Point point = new Point(6, 9);
            point.MoveHorz(7);
            Rectangle rectangle = new Rectangle(10, 24, 78, 100);
            Console.WriteLine("Rectangle ACBD");
            rectangle.Display();
            Console.WriteLine($"Площадь прямоугольника: {rectangle.GetSquare()}");
            rectangle.Colour = "White";
            rectangle.MoveVert(-7);
            Console.WriteLine("Point: ");
            point.Display();
            
        }
    }
}
