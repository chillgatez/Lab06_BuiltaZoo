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

        public Animal(string name)
        {
            this.name = name;
        }

        public abstract void Eat();
        public abstract void Sleep();
        public abstract string Sound();
        public virtual string Habitat
        {
            get { return "Unknown"; }
        }
    }
}
