using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodichka
{
    class Rectangle:Point
    {
        private double pointBx;
        private double pointBy;
        public Rectangle(double x1, double y1, double x2, double y2) 
        {
            pointBx = x2;
            pointBy = y2;
        }
        public Rectangle()
        {

        }
        public override void Display()
        {
            Console.WriteLine("Point D:");
            Console.WriteLine($"x = {pointBx}");
            Console.WriteLine($"y = {pointAy}");
            Console.WriteLine("Point C:");
            Console.WriteLine($"x = {pointAx}");
            Console.WriteLine($"y = {pointBy}");
            Console.WriteLine("Point B:");
            Console.WriteLine($"x = {pointBx}");
            Console.WriteLine($"y = {pointBy}");
            Console.WriteLine("Point A:");
            base.Display();
        }
        public override void MoveHorz(double delta)
        {
            pointAx += delta;
            pointBx += delta;
        }
        public override void MoveVert(double delta)
        {
            pointAy += delta;
            pointBy += delta;
        }
        public double GetSquare()
        {
            return Math.Abs((pointAx - pointBx) * (pointAy - pointBy));
        }
    }
}
