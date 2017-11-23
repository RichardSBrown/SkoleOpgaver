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
            name = "Geo";
            count = 55;
            
        }
        
    }
    class Ørred : Fisk
    {
        public Ørred()
        {
            count = 42;
        }

    }
    class Rødspætte : Fisk
    {
        public Rødspætte()
        {
            count = 22;
        }
    }
}
