using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPets
{
    class Pet
    {
        public Specie spicie;
        public string name;
        public Pet(Specie spicie, string name)
        {
            this.spicie = spicie;
            this.name = name;
        }
    }
}
