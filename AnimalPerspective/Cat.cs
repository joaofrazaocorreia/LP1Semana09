using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective
{
    public class Cat : Animal, IMammal
    {
        public override string Sound()
        {
            return "Miau";
        }

        public int NumberOfNipples{ get => 6; }
    }
}