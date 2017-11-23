using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.CheckAllAnimals();
            foreach (string dyr in Animal.Dyreliste)
            {
                Console.WriteLine(dyr);
            }
            Pingvin pingvin = new Pingvin();
            int count = pingvin.getcount(); //Virker også, og ser mere ud som noget mads ønsker
            Console.WriteLine(count);
            Console.WriteLine("The End");
            Console.ReadKey();
        }
    }
}
