using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodichka
{
    class Circle: Point
    {
        public double Radius { get; set; }
        public Circle()
        {

        }
        public Circle(double xCenter, double yCenter, double radius) : base(xCenter, yCenter)
        {
            Radius = radius;
        }
       
        public override void Display()
        {
            Console.WriteLine($"Radius = {Radius}");
            base.Display();
        }
        public double GetSquare()           
        {
            return Math.PI * Radius * Radius;
        }
    }
}
