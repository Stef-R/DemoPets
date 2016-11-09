using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPets
{
    class Specie
    {
        public string name;
        public int numbersOfEyes;
        public int numbersOfLegs;

        public Specie(string name,int numbersOfEyes,int numbersOfLegs)
        {
            this.name = name;
            this.numbersOfEyes = numbersOfEyes;
            this.numbersOfLegs = numbersOfLegs;
        }
    }
}
