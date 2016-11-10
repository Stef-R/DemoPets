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
            Specie dyreart = new Specie("Hund", 4, 2);
            Pet steenshund = new Pet(dyreart, "King");
            Person steen = new Person("Steen", 1958, steenshund);
            System.Console.WriteLine("svar:{0}", steen.Pet.Spicie.Name);
            System.Console.ReadKey();

            // steen.OnNameChanged() 

            System.Console.WriteLine("Person navn: {0}", steen.getName());
            System.Console.WriteLine("Person alder: {0}", steen.getAlder());
            System.Console.WriteLine("Person kæledyrs antal øjne: {0}", steen.getPeronsPetsNumberOfEyes());
            System.Console.ReadKey();
        }
    }
}
