using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public abstract class Animal
    {
        // Common properties for all animals
        protected internal string name;
        protected internal int numberOfLegs;
        protected internal string Family;

        // Constructor to initialize common properties
        public Animal(string name, int numberOfLegs, string Family)
        {
            this.name = name;
            this.numberOfLegs = numberOfLegs;
            this.Family = Family;
        }
        // Abstract methods to be implemented by derived classes
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

        // Virtual properties to be overridden by derived classes
        public virtual string Habitat { get; set; }
    }
}