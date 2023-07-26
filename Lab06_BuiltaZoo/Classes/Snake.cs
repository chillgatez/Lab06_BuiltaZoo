﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_BuiltaZoo.Classes
{
    public class Snake : Reptile
    {
        public Snake(string name, bool hasScales) : base(name, 0, "Serpentes", hasScales)
        {
            CanSwim = true;
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

        public override bool LaysEggs()
        {
            return true;
        }

        public override bool IsNocturnal { get; set; } = true;
    }
}