using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Dog
    {
        public int Id { get; private set; }
        public string name;
        public DateTime dateOfBirth;
        StageOfLife StageOfLife; 
        public int Weight;

        public Dog(string name, DateTime dateofbirth, int stageoflife, int weight)
        {

        }

        public string getName()
        {
            return name;
        }

        public int getId()
        {
            return Id;
        }

    }
}
