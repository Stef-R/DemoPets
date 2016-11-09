using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPets
{
    class Person
    {
        public String name;
        public int yearBorn;
        public Pet pet;
        public Person(string name,int yearBorn, Pet pet)
        {
            this.name = name;
            this.yearBorn = yearBorn;
            this.pet = pet;
        }
    }
}
