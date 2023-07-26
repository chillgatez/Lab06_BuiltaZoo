using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public class Iguana : Reptile
    {
        public Iguana(string name, bool hasScales) : base(name, 4, "Iguanidae", hasScales)
        {
            CanSwim = false;
            Habitat = "Tropical forest";
        }

        public override void Eat()
        {
            Console.WriteLine($"{name} ate the cricket in the corner.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{name} is sleeping on a warm rock.");
        }

        public override string Sound()
        {
            return "Wheeze";
        }

        public override bool LaysEggs()
        {
            return true;
        }
        public override bool IsNocturnal { get; set; } = true;
    }
}
