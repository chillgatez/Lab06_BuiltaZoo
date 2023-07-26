using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public abstract class Mammal : Animal
    {
        // Additional property specific to mammals
        protected internal string FurColor;

        // Constructor to initialize mammal properties
        public Mammal(string name, int numberOfLegs, string Family, string FurColor) : base(name, numberOfLegs, Family)
        {
            this.FurColor = FurColor;
        }

        // Override the WarmBlooded() method for mammals
        public override void WarmBlooded()
        {
            Console.WriteLine($"{name} is warm-blooded.");
        }
    }
}
