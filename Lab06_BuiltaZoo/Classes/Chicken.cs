using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public class Chicken : Bird, ILayEggs
    {
        public Chicken(string name, bool canFly) : base(name, "Phasianidae", canFly)
        {
            Habitat = "Farm";
        }

        public override void Eat()
        {
            Console.WriteLine($"{name} is pecking at seeds.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{name} is roosting.");
        }

        public override string Sound()
        {
            return "Cluck";
        }

        public void LayingEggs()
        {
            Console.WriteLine($"Lay one egg at a time");
        }

    }
}
