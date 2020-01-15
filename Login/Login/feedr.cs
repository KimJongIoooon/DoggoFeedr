﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Feedr
    {
        public int id { get; private set; }
        int foodLevel;
        List<DateTime> mealtimes;
        public Dog dog { get; private set; }
        Food food;
        bool isActive;
        public Feedr(int id, int foodlevel, List<DateTime> mealtimes, Dog dog, Food food, bool isActive)
        {
            this.id = id;
            this.foodLevel = foodlevel;
            this.mealtimes = mealtimes;
            this.dog = dog;
            this.food = food;
            this.isActive = isActive;
        }
    }

    
}
