using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigrush
{
    class Fishing:IPlayGame
    {
            public int Play()
            {
                Console.WriteLine("Игра \"Рыбалка\"");
                Random R = new Random();
                return R.Next(1, 10);
            }
        }
    }

