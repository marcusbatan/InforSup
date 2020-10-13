using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class StatRepository
    {
        public bool addLine(int goals, int assists)
        {
            using (var db = new SimonOMarcusEntities())
            {
                var stats = new Stat
                {
                    StatId = Guid.NewGuid(),
                    Goals = goals,
                    Assists = assists
                };
                db.Stat.Add(stats);
                db.SaveChanges();
                return true;
            }
        }
    }
}

