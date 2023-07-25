using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public abstract class Animal
    {
        protected internal string name;
        protected internal int numberOfLegs;
        protected internal string family;

        public Animal(string name, int numberOfLegs, string family)
        {
            this.name = name;
            this.numberOfLegs = numberOfLegs;
            this.family = family;
        }

        public abstract void Eat();
        public abstract void Sleep();
        public abstract string Sound();

        // Warm-blooded behavior (default implementation)
        public virtual void WarmBlooded()
        {
            Console.WriteLine($"{name} is warm-blooded.");
        }

        // Cold-blooded behavior (default implementation)
        public virtual void ColdBlooded()
        {
            Console.WriteLine($"{name} is cold-blooded.");
        }
    }
}