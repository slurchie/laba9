using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigrush
{
    class BigGame
    {
        public IPlayGame[] games = new IPlayGame[6];
        public BigGame()
        {
            Random R = new Random();
            List<IPlayGame> game = new List<IPlayGame>(7);
            game.Add(new Beach());
            game.Add(new Mousetrap());
            game.Add(new Sea());
            game.Add(new Fishing());
            game.Add(new Postmen());
            game.Add(new Slide());
            game.Add(new DontBreakTheCookie());
            for (int i = 6; i >= 1; i--)
            {
                int j = R.Next(i + 1);
                var temp = game[j];
                game[j] = game[i];
                game[i] = temp;
            }
            for (int i = 0; i < 6; i++)
            {
                games[i] = game[i];
            }
        }
        public int PlayGames(BigGame game)
        {
            int score = 0;
            for (int i = 0; i < 6; i++)
            {
                score += game.games[i].Play();
            }
            return score;
        }
    }
}
