using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public abstract class Reptile : Animal
    {
        protected internal bool HasScales { get; set; }

        public Reptile(string name, int numberOfLegs, string family, bool hasScales) : base(name, numberOfLegs, family)
        {
            HasScales = hasScales;
        }

        // Override the ColdBlooded() method for reptiles
        public override void ColdBlooded()
        {
            Console.WriteLine($"{name} is cold-blooded.");
        }

        public abstract bool LaysEggs();
    }
}
