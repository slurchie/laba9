using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigrush
{
    class Slide : IPlayGame
    {
        public int Play()
        {
            Console.WriteLine("Игра \"Горка\"");
            Random R = new Random();
            return R.Next(1, 10);
        }
    }
}
