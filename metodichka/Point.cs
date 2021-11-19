using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodichka
{
    class Point : Figure
    {
        public double pointAx;
        public double pointAy;
        public Point()
        {

        }
        public Point(double x, double y)
        {
            pointAx = x;
            pointAy = y;
        }
        public override void Display()
        {
            Console.WriteLine($"x = {pointAx}");
            Console.WriteLine($"y = {pointAy}");
            Console.WriteLine($"Visual: " + Visual);
            Console.WriteLine($"Colour: {Colour}");
        }
        public override void MoveHorz(double delta)
        {
            pointAx += delta;
        }
        public override void MoveVert(double delta)
        {
            pointAy += delta;
        }
    }
}

