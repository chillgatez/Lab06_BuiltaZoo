using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public class Snake : Reptile, ISwimming
    {
        public Snake(string name, bool hasScales) : base(name, 0, "Serpentes", hasScales)
        {
            Habitat = "Swamp";
        }

        public override void Eat()
        {
            Console.WriteLine($"{name} has swallowed a mouse.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{name} is not sleeping when you are.");
        }

        public override string Sound()
        {
            return "Hiss";
        }

        public void Swim()
        {
            Console.WriteLine($"{name} winds through the water.");
        }

        public void LayingEggs()
        {
            Console.WriteLine($"Lay a clutch of 2-40 eggs depending on the species.");
        }
    }
}