using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public class Chicken : Bird
    {
        public Chicken(string name, bool canFly, string species) : base(name, canFly, species)
        {
        }

        public override void Eat()
        {
            Console.WriteLine($"{name} is pecking at food.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{name} is roosting.");
        }

        public override string Sound()
        {
            return "Cluck";
        }

        public override bool LaysEggs()
        {
            return true;
        }

        public override string Habitat
        {
            get { return "Farm"; }
        }
    }
}
