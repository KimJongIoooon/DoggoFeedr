using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Food
    {
        public int Id { get; private set; }
        public string name { get; private set; }
        public int energyContent { get; private set; }//energy per volume in Colories per m/2
        
        public Food()
        {

        }
        public Food(int id, string name, int energyContent)
        {
            this.Id = id;
            this.name = name;
            this.energy = energy;
        }
    }
}
