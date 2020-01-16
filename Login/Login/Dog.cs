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
        public int stageOfLife { get; private set; } 
        public int Weight;

        public Dog()
        {

        }

        public int getEnergieBehoefte()
        {

            double EnergieBehoefte;
            
            switch (stageOfLife)
            {
                case 0:
                    EnergieBehoefte = 460 * Math.Pow(20, 0.75);
                    break;
                case 1:
                    EnergieBehoefte = 460 * Math.Pow(20, 0.75);
                    break;
                case 2:
                    EnergieBehoefte = 460 * Math.Pow(20, 0.75);
                    break;
                case 3:
                    EnergieBehoefte = 460 * Math.Pow(20, 0.75);
                    break;
                default:
                    throw new Exception("error energie behofte");
                    break;
            }

            
            return energieBehoefte;
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

        public override string ToString()
        {
            return Name;
        }
    }
}
