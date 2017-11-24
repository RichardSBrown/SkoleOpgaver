using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Fugle : Animal
    {      
        public Fugle()
        {
            
        }
    }
    class Pingvin : Fugle
    {
        public Pingvin()
        {
            count = 1;
            name = "Pingvin";
        }
    }
    class Spætte : Fugle
    {
        public Spætte()
        {
            count = 3;
            name = "Spætte";
        }
    }
    class Stork : Fugle
    {
        public Stork()
        {
            count = 2;
            name = "Stork";
        }
    }
}
