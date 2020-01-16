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
        int stageOfLife; 
        public int Weight;

        public Dog()
        {

        }
        public Dog(int Id, string name, DateTime dateofbirth, int stageoflife, int weight)
        {
            this.Id = Id; 
            this.Name = name;
            this.dateOfBirth = dateofbirth;
            this.stageOfLife = stageoflife;
            this.Weight = weight;
        }
        public Dog(string name, DateTime dateofbirth, int stageoflife, int weight)
        {
            this.Name = name;
            this.dateOfBirth = dateofbirth;
            this.stageOfLife = stageoflife;
            this.Weight = weight;
        }

        public Dog(string name, int accountid, DateTime dateofbirth, int stageoflife, int weight)
        {
            this.Name = name;
            this.dateOfBirth = dateofbirth;
            this.stageOfLife = stageoflife;
            this.Weight = weight;
        }

    }
}
