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
        public void AddLøver()
        {
            int i = 0;
            count = 55;
            while (i <= count)
            {
                Dyreliste.Add(listcount + " Løve");
                i++;
                listcount++;
            }


        }

    }
    class Tiger : Rovdyr
    {
        public void AddTiger()
        {
            int i = 0;
            count = 88;
            while (i <= count)
            {
                Dyreliste.Add(listcount + " Tiger");
                i++;
                listcount++;
            }
        }

    }
    class Leopard : Rovdyr
    {
        public Leopard()
        {
            count = 76;
        }

    }
}