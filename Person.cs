using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPets
{
    class Person : INotifyPropertyChanged
    {
        private string name;
        private int yearBorn;
        private Pet pet;
        private EventHandler<string> NameChanged;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get { return name; }
            set
            {
                if (this.Name != value)
                {

                    this.name = value;
                    OnNameChanged();
                    // on
                }
            }
        }
        public int YearBorn { get { return yearBorn; } }
        public Pet Pet { get { return pet; } }

        public void OnNameChanged()
        {
            EventHandler<string> handler = NameChanged;
            if (NameChanged != null)
            {
                handler(this, this.name);
            }
        }
        //public 

        public Person(string name, int yearBorn, Pet pet)
        {
            this.name = name;
            this.yearBorn = yearBorn;
            this.pet = pet;
        }
        public Person(string name) : this(name, 0, null) { }
        public Person(string name, Pet pet) : this(name, 0, pet) { }
        public Person(string name, string petName, Specie specie)
        {
            this.name = name;
            Pet newPet = new Pet(specie, petName);
            this.pet = newPet;
        }

        public string getName()
        {
            return this.Name;
        }
        public int getAlder()
        {
            return System.DateTime.Now.Year - this.YearBorn;
        }
        public int getPeronsPetsNumberOfEyes()
        {
            return pet.Spicie.NumbersOfEyes;
        }

        private void OnPropertyChanged(string propertyName)
        {
            ProgressChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new ProgressChangedEventArgs(propertyName));
            }
        }


    }
}
