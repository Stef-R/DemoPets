using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPets
{
    class Program
    {
        static void Main(string[] args)
        {
            Specie dyreart = new Specie("Hund",4,2);
            Pet steenshund = new Pet(dyreart, "King");
            Person steen = new Person("Steen", 1958, steenshund);
        }
    }
}
