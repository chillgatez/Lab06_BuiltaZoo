using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public class Duck : Bird, ISwimming
    {
        public Duck(string name, bool canFly) : base(name, "Anatidae", canFly)
        {
            Habitat = "Wetlands";
        }

        public override void Eat()
        {
            Console.WriteLine($"{name} is eating breadcrumbs on cheat day.");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{name} stands on one leg to sleep.");
        }

        public override string Sound()
        {
            return "Quack";
        }

        public void Swim()
        {
            Console.WriteLine($"{name} swims gracefully.");
        }

        public void LayingEggs()
        {
            Console.WriteLine($"Lay a clutch of 6-12 eggs at a time.");
        }

    }
}