using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Name = "penguin";
            IsMammal = false;
            NumberOfLegs = 2;
            Color = "black";
            Sound = "sound 1";
        }

            public bool canFly { get; set; }

            public int wingLength { get; set; }
            public string wingColor { get; set; }
            public bool canSwim { get; set; }

        
    }


   
}
