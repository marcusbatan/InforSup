using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class GamesRepository
    {
        public bool AddGame(string id, int? homeScore, int? awayScore, string homeTeam, string awayTeam)
        {
            using (var context = new SimonOMarcusEntities())
            {
                var game = new Games
                {
                    GameId = id,
                    AwayTeam = awayTeam,
                    HomeTeam = homeTeam,
                    HomeScore = homeScore,
                    AwayScore = awayScore
                };
                context.Games.Add(game);
                context.SaveChanges();
                return true;
            }
        }
    }
}
