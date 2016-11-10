﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPets
{
    class Person
    {
        private string name;
        private int yearBorn;
        private Pet pet;

        public string Name { get { return name; } }
        public int YearBorn { get { return yearBorn; } }
        public Pet Pet { get { return pet; } }

        public Person(string name,int yearBorn, Pet pet)
        {
            this.name = name;
            this.yearBorn = yearBorn;
            this.pet = pet;
        }
        public Person(string name):this(name, 0, null)  {}
        public Person(string name,Pet pet) : this(name,0,pet) { }
        public Person(string name, string petName, Specie specie)
        {
            this.name = name;
            Pet newPet = new Pet(specie, petName);
            this.pet=newPet;
        }

        public string getName()
        {
            return this.Name;
        }
        public int getAlder()
        {
            return System.DateTime.Now.Year-this.YearBorn;
        }
        public int getPeronsPetsNumberOfEyes()
        {
            return pet.Spicie.NumbersOfEyes;
        }



    }
}
