using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public class Snake : Reptile
    {
        protected internal bool venomous;

        public Snake(string name, int numberOfLegs, bool venomous) : base(name, numberOfLegs)
        {
            this.venomous = venomous;
        }

        public override void Eat()
        {
            Console.WriteLine($"{name} is eating.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{name} is sleeping.");
        }

        public override string Sound()
        {
            return "Hiss";
        }

        public override void ColdBlooded()
        {
            Console.WriteLine($"{name} is cold-blooded.");
        }

        public override string Habitat
        {
            get { return "Grass"; }
        }
    }
}
