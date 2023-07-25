using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public class Cat : Mammal
    {
        protected internal string furColor;

        public Cat(string name, int numLegs, string furColor) : base(name, numLegs)
        {
            this.furColor = furColor;
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
            return "Meow";
        }

        public override void WarmBlooded()
        {
            Console.WriteLine($"{name} is warm-blooded.");
        }
    }
}
