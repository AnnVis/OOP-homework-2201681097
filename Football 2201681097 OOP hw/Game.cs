using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_2201681097_OOP_hw
{
    public class Game
    {
        private Team team1 { get; set; }
        private Team team2 { get; set; }
        public Team Team1
        {
            get { return team1; }
            private set
            {
                if (value.Player.Count == 11)
                {
                    team1 = value;
                }
                else
                    throw new ArgumentException("The team must have 11 players.");

            }
        }
        public Team Team2
        {
            get { return team2; }
            private set
            {
                if (value.Player.Count == 11)
                {
                    team2 = value;
                }
                else
                    throw new ArgumentException("The team must have 11 players.");
            }
        }
        public Referee Referee { get; set; }
        private List<Referee> referees { get; set; } = new List<Referee>();
        public List<Referee> Referees
        {
            get { return referees; }
            private set
            {
                if (value.Count == 2)
                {
                    referees = value;
                }
            }
        }
        public List<Goal> goals { get; set; } = new List<Goal>();
        public Game(Team team1, Team team2)
        {
            Team1 = team1;
            Team2 = team2;
        }
        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }
        public int[] GetGameResult()
        {
            int[] result = { 0, 0 };

            foreach (var goal in goals)
            {
                if (team1.Player.Contains(goal.Player))
                {
                    result[0]++;
                }
                else if (team2.Player.Contains(goal.Player))
                {
                    result[1]++;
                }
            }
            return result;
        }
        public Team? GetWinner()
        {
            int[] result = GetGameResult();
            if (result[0] > result[1])
            {
                return team1;
            }
            else if (result[1] > result[0])
            {
                return team2;
            }
            else
            {
                return null;
            }
        }
    }
}
