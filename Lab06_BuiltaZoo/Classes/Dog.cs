using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public class Dog : Mammal
    {
        public Dog(string name, string FurColor) : base(name, 4, "Canidae", FurColor)
        {
            CanSwim = true;
            Habitat = "Domestic";
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
            return "Woof";
        }

        public override void WarmBlooded()
        {
            Console.WriteLine($"{name} is warm-blooded.");
        }

        public override bool IsNocturnal { get; set; } = false;
    }
}
