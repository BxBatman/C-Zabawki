using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PokojZabawek
    {
        List<Zabawka> lista = new List<Zabawka>(); 



        public void add(Zabawka zabawka)
        {
            lista.Add(zabawka);
        }

        public void zmienSzybkosc()
        {
            foreach(Zabawka zabawka in lista)
            {
                zabawka.Szybkosc+=2;
            }
        }

        public void zmienWysokosc()
        {
            foreach (Zabawka zabawka in lista)
            {
            }

        }

        public void zmienGlebokosc()
        {
            foreach (Zabawka zabawka in lista)
            {
                zabawka.Glebokosc++;

            }
        }


        public void wyswietl()
        {
            foreach (Zabawka zabawka in lista)
            {
                Console.WriteLine("Szybkosc zabawki " + zabawka.Szybkosc);
            }

            Console.ReadLine();
        }

    }
}
