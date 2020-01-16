using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Feedr
    {
        public int id { get; private set; }
        List<DateTime> mealtimes;
        public int puzzle { get; private set; }
        public Dog dog { get; private set; }
        public Food food { get; private set; }
        public bool isActive { get; private set; }
        public int foodPerMeal { get; private set; }
        public int foodLevel { get; private set; }
        public List<LogEntry> log { get; private set; }
        public Feedr(int id, int foodlevel, List<DateTime> mealtimes, Dog dog, Food food, bool isActive)
        {
            this.id = id;
            this.foodLevel = foodlevel;
            this.mealtimes = mealtimes;
            this.dog = dog;
            this.food = food;
            this.isActive = isActive;
        }

        public Feedr(int id, int foodlevel, List<DateTime> mealtimes, Dog dog, Food food, int puzzle, bool isActive)
        {
            this.id = id;
            this.foodLevel = foodlevel;
            this.mealtimes = mealtimes;
            this.dog = dog;
            this.food = food;
            this.puzzle = puzzle;
            this.isActive = isActive;
        }

        public Feedr updateFeedr(int id, Dog dog, int puzzle)
        {
            this.id = id;
            this.dog = dog;
            this.puzzle = puzzle;
            return this;
        }

    }

    
}
