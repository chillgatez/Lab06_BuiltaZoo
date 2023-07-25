using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public abstract class Bird : Animal
    {
        protected internal bool canFly;

        public Bird(string name, bool canFly) : base(name)
        {
            this.canFly = canFly;
        }

        public abstract bool LaysEggs();

    }
}
