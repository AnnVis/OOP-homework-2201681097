using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_2201681097_OOP_hw
{
    public class Goal
    {
        public double Minute { get; private set; }
        public Football_player Player { get; private set; }
        public Goal(double minute, Football_player player)
        {
            Minute = minute;
            Player = player;
        }
    }
}
