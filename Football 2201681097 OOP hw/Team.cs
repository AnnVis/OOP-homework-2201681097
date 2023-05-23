using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_2201681097_OOP_hw
{
    public class Team
    {
        public Coach Coach { get;private set; }
        public List<Football_player> players;
        public List<Football_player> Player {
            get { return players; }
            private set 
            {
                if (value.Count >= 11 && value.Count <= 22)
                {
                    players = value;
                }
                else
                {
                    throw new ArgumentException("A team must have between 11 and 22 players");
                }
            }
        }
      
        public Team(Coach coach, List<Football_player> players)
        {
            Coach = coach;
            Player = players;
        }

        public double GetAveragePlayerAge()
        {
            List<int> ages = new List<int>();
            foreach (var player in Player)
            {
                ages.Add(player.Age);
            }
            return ages.Average();
        }
    }
}
