using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    internal class Animal
    {
        protected string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public abstract void Eat();
        public abstract void Sleep();
        public abstract string Sound();

        public abstract class Mammal : Animal
        {
            protected int numberOfLegs;

            public Mammal(string name, int numberOfLegs) : base(name)
            {
                this.numberOfLegs = numberOfLegs;
            }

            public abstract void WarmBlooded();
        }
    }
}
