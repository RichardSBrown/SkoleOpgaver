using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Fisk : Animal
    {
        public Fisk()
        {
            count = 3; //There is 3 kind of fish
        }
    }
    class Guldfisk : Fisk
    {
        public Guldfisk()
        {
            name = "Guldfisk";
            count = 5;
            
        }
        
    }
    class Ørred : Fisk
    {
        public Ørred()
        {
            name = "Ørred";
            count = 4;
        }

    }
    class Rødspætte : Fisk
    {
        public Rødspætte()
        {
            name = "Rødspætte";
            count = 2;
        }
    }
}
