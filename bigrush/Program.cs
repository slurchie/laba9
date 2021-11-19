using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigrush
{
    class Program
    {
        static void Main()
        {
            Team[] teams = new Team[4];
            teams[0] = new Team("Россия");
            teams[1] = new Team("Франция");
            teams[2] = new Team("Китай");
            teams[3] = new Team("Украина");
            BigGame[] games = new BigGame[6];
            for (int i = 0; i < 6; i++)
            {
                games[i] = new BigGame();
            }
            Team winner = teams[0];
            int scoreWinner = 0;
            foreach (Team T in teams)
            {
                int score = 0;
                Console.WriteLine("Команда " + T.Name + " начала проходить испытания");
                foreach (BigGame G in games)
                {
                    Console.WriteLine("Начата новая игра");
                    int currentScore = T.PlayGames(G);
                    score += currentScore;
                    Console.WriteLine("По итогам 6 испитаний команда набрала " + currentScore);
                }
                if (score > scoreWinner)
                {
                    winner = T;
                    scoreWinner = score;
                }
            }
            Console.WriteLine("Победила " + winner.Name);
        }
    }
}


