using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigrush
{
    class Team
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {

            }
        }
        List<Player> players = new List<Player>(15);
        public Team(string Name)
        {
            name = Name;
            for (int i = 0; i < 15; i++)
            {
                players.Add(new Player());
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
