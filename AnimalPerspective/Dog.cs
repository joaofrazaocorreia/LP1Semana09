using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective
{
    public class Dog : Animal, IMammal
    {
        public override string Sound()
        {
            return "Woof!";
        }

        public int NumberOfNipples{ get => 8; }
    }
}