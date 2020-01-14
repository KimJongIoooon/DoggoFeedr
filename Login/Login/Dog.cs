using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Dog
    {
        public int Id { get; private set; }
        public string Name;
        public DateTime dateOfBirth;
        StageOfLife StageOfLife; 
        public int Weight;

        public Dog(string name, DateTime dateofbirth, int stageoflife, int weight)
        {
            Name = name;
            dateOfBirth = dateofbirth;
            stageOfLife = stageoflife;
            Weight = weight;
        }
    }
}
