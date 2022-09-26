using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {

        public Reptile() //Constructor
        {
            IsMammal = false;
            NumberOfLegs = 0;
            Color = "black";
            Sound = "sound 1";
        }
        public int AverageLength;
        public int AverageWeight { get; set; }
        public bool CanGrowTail { get; set; }
        public string Habitat { get; set; }
    }
}
