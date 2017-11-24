using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Zoo : Animal
    {
        public void UI()
        {
            bool Programrun = true;
            while (Programrun == true)
            {
                Console.Clear();
                Console.WriteLine("Velkommen til!");
                Console.WriteLine("/dyr for at se alle dyr\n/rovdyr for at se alle rovdyr \n/fisk for at se alle fisk \n/fugle for at se alle fugle");
                string userinput = Console.ReadLine().ToLower();
                if (userinput == "/quit")
                {
                    Programrun = false;
                }
                if (userinput == "/dyr")
                {
                    CheckAllAnimals();
                    ShowList();
                    Console.ReadKey();
                }
                if (userinput == "/rovdyr")
                {
                    CheckRovdyr();
                    ShowList();
                    Console.ReadKey();
                }
                if (userinput == "/fugle")
                {
                    CheckFugle();
                    ShowList();
                    Console.ReadKey();
                }
                if (userinput == "/fisk")
                {
                    CheckFisk();
                    ShowList();
                    Console.ReadKey();
                }
            }
        }

    }
}
