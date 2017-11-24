using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Rovdyr : Animal
    {
        public Rovdyr()
        {
            count = 3;
        }

    }
    class Løver : Rovdyr
    {
        public Løver()
        {
            name = "Løver";
            count = 5;
        }

    }
    class Tiger : Rovdyr
    {
        public Tiger()
        {
            name = "Tiger";
            count = 5;
        }

    }
    class Leopard : Rovdyr
    {
        public Leopard()
        {
            name = "Leopard";
            count = 7;
        }

    }
}