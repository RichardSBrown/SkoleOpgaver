using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Animal
    {
        public static List<string> Dyreliste = new List<string>();
        protected int count;
        protected string name;
        protected static int listcount = Dyreliste.Count + 1;
        public bool status;

        public void CheckAllAnimals() //Dette virker, men tror ikke det er det mads er ude efter / Jeg håber det virkelig ikke, fordi det er for meget copy/paste og kedeligt.
        {
            status = true;
            listcount = 1;
            Dyreliste.Clear();
            Console.Clear();
            Dyreliste.Add("ID: Art:");
            //RovDyr
            CheckRovdyr();
            //Fisk
            CheckFisk();
            //Fugle
            CheckFugle();
            status = false;
        }
        public void CheckRovdyr()
        {
            if (status == false)
                {
                Dyreliste.Clear();
                listcount = 1;
                Dyreliste.Add("ID: Art:");
                Console.Clear();
            }
            Løver løver = new Løver();
            Tiger tiger = new Tiger();
            Leopard leopard = new Leopard();
            count = løver.getcount();
            name = løver.getname();
            AddToList();
            count = tiger.getcount();
            name = tiger.getname();
            AddToList();
            count = leopard.getcount();
            name = leopard.getname();
            AddToList();
        }
        public void CheckFisk()
        {
            if (status == false)
            {
                Dyreliste.Clear();
                listcount = 1;
                Dyreliste.Add("ID: Art:");
                Console.Clear();
            }
            Guldfisk guldfisk = new Guldfisk();
            Ørred ørred = new Ørred();
            Rødspætte rødspætte = new Rødspætte();
            count = guldfisk.getcount();
            name = guldfisk.getname();
            AddToList();
            count = ørred.getcount();
            name = ørred.getname();
            AddToList();
            count = rødspætte.getcount();
            name = rødspætte.getname();
            AddToList();
        }
        public void CheckFugle()
        {
            if (status == false)
            {
                Dyreliste.Clear();
                listcount = 1;
                Dyreliste.Add("ID: Art:");
                Console.Clear();
            }
            Pingvin pingvin = new Pingvin();
            Spætte spætte = new Spætte();
            Stork stork = new Stork();
            count = pingvin.getcount();
            name = pingvin.getname();
            AddToList();
            count = spætte.getcount();
            name = spætte.getname();
            AddToList();
            count = stork.getcount();
            name = stork.getname();
            AddToList();
        }
        public int getcount()
        {
            return count;
        }
        public void setcount(int c)
        {
            this.count = c;
        }
        public string getname()
        {
            return name;
        }
        public void setname(string q)
        {
            this.name = q;
        }
        public void AddToList()
        {
            int countdown = 0;
            while (countdown <= count)
            {
                Dyreliste.Add(listcount + " " + name);
                countdown++;
                listcount++;
            }

        }
        public void ShowList()
        {
            foreach (string dyr in Dyreliste)
            {
                Console.WriteLine(dyr);
            }
        }
    }
}
