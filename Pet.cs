using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPets
{
    class Pet
    {
        private Specie spicie;
        private string name;

        public Specie Spicie { get { return spicie; } }
        public string Name { get { return name; } }

        public Pet(Specie spicie, string name)
        {
            this.spicie = spicie;
            this.name = name;
        }
    }
}
