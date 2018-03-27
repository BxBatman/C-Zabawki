using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Wartosc wartosc1 = new Wartosc(23, 300);
            Zabawka zabawka = new Zabawka(1, 2, 3,wartosc1,20);
            PokojZabawek pokojZabawek = new PokojZabawek();
            pokojZabawek.add(zabawka);
            pokojZabawek.wyswietl();
            pokojZabawek.zmienSzybkosc();
            pokojZabawek.wyswietl();
            Console.WriteLine(zabawka.WartoscAktualna);
            Console.ReadLine();
        }
    }
}
