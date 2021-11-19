using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigrush
{
    class DontBreakTheCookie : IPlayGame
    {
        public void GetCookie()
        {
            Console.WriteLine("Печенька");
        }
        public int Play()
        {
            Console.WriteLine("Игра \"Сломать печеньку\"");
            Random R = new Random();
            return R.Next(1, 10);
        }
    }
}
