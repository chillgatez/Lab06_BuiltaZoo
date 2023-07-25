using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public abstract class Mammal : Animal
    {
        protected internal string furColor;

        public Mammal(string name, int numberOfLegs, string family, string furColor) : base(name, numberOfLegs, family)
        {
            this.furColor = furColor;
        }

        // Override the WarmBlooded() method for mammals
        public override void WarmBlooded()
        {
            Console.WriteLine($"{name} is warm-blooded.");
        }
    }
}
