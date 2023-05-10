using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective
{
    public class Bat : Animal, IMammal, ICanFly
    {
       public override string Sound()
        {
            return "Squeak!";
        } 

        public int NumberOfNipples{ get => 2; }
        public int NumberOfWings{ get => 2; }
    }
}