using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public abstract class Bird : Animal
    {
        protected internal bool canFly { get; set; }

        public Bird(string name, string family, bool canFly) : base(name, 2, family)
        {
            this.canFly = canFly;
        }

        // Override the WarmBlooded() method for birds
        public override void WarmBlooded()
        {
            Console.WriteLine($"{name} is warm-blooded.");
        }

        public abstract bool LaysEggs();
    }
}
