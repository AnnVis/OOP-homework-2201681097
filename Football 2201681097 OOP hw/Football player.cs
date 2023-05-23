﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_2201681097_OOP_hw
{
    public class Football_player:Person
    {
        public int Number { get;private set; }
        public double Height { get;private set; }
        public Football_player(string name, int age,int number, double height)
            :base(name,age)
        {
            Number = number;
            Height = height;
        }
    }
}
