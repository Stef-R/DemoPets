using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPets
{
    class Specie
    {
        private string name;
        private int numbersOfEyes;
        private int numbersOfLegs;

        public string Name
        {
            get
            {
                return name;
            }

        }
        public int NumbersOfEyes { get { return numbersOfEyes; } }
        public int NumbersOfLegs { get { return numbersOfLegs; } }


        public Specie(string name, int numbersOfEyes, int numbersOfLegs)
        {
            this.name = name;
            this.numbersOfEyes = numbersOfEyes;
            this.numbersOfLegs = numbersOfLegs;
        }
    }
}
