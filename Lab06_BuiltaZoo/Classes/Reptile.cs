using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public abstract class Reptile : Animal
    {
        protected internal int numberOfLegs;

        public Reptile(string name, int numberOfLegs) : base(name)
        {
            this.numberOfLegs = numberOfLegs;
        }

        public abstract void ColdBlooded();
    }
}
