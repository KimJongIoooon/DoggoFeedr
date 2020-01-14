using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Feedr
    {
        int id;
        int foodLevel;
        List<DateTime> mealtimes;
        Dog dog;
        Food food;
        bool isActive;
        public Feedr(int id, int foodlevel, List<DateTime> mealtimes, Dog dog, Food food, bool isActive)
        {
            id = id;


        }
    }

    
}
