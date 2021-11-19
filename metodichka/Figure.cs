using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodichka
{
     abstract class Figure
    {
        public string Colour { get; set; }
        public bool Visual { get; set; } = true;
        abstract public void MoveHorz(double delta);
        abstract public void MoveVert(double delta);
        abstract public void Display();
    }
}
