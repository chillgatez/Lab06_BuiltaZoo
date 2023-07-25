using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public class Animal
    {
        protected string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public abstract void Eat();
        public abstract void Sleep();
        public abstract string Sound();

    }
}
