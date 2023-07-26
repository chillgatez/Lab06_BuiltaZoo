using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public class Duck : Bird
    {
        public Duck(string name, bool canFly) : base(name, "Anatidae", canFly)
        {
            CanSwim = true;
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

        public override bool LaysEggs()
        {
            return true;
        }

        public override bool IsNocturnal { get; set; } = false;
    }
}