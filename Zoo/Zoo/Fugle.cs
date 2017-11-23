using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Fugle : Animal
    {
        protected int pingvincount;
        protected int spættecount;
        protected int storkcount;
        
        
        public Fugle()
        {
            fulgecount = pingvincount + spættecount + storkcount; //Mulighed for at få vist hvor mange fulge der er OBS! uden et navn.
        }

    }
    class Pingvin : Fugle
    {
        public Pingvin()
        {
            count = 117;
            pingvincount = count;
        }
        
    }
    class Spætte : Fugle
    {
        public Spætte()
        {
            count = 3050;
            spættecount = count;
        }

    }
    class Stork : Fugle
    {
        public Stork()
        {
            count = 2; //De andre leverde baby'er
            storkcount = count;
        }

    }
}
