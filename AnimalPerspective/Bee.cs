using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective
{
    public class Bee : Animal, ICanFly
    {
        public override string Sound()
        {
            return "Buzzz";
        }

        public int NumberOfWings{ get => 4; }
    }
}