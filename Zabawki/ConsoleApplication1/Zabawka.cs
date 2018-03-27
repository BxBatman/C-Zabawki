using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{   
    struct Wartosc
    {
        double cena;
        double wartoscSentymentalna;

        public double Cena
        {
            get
            {
                return cena;
            }

            set
            {
                if (value > 0)
                {
                    cena = value;
                }else
                {
                    Console.WriteLine("Cena musi byc wieksza od 0");
                    Console.ReadLine();
                }
            }
        }

        public double WartoscSentymentalna
        {
            get
            {
                return wartoscSentymentalna;
            }

            set
            {
                wartoscSentymentalna = value;
            }
        }

        public Wartosc(double cena,double wartoscSentymentalna)
        {
            this.cena = cena;
            this.wartoscSentymentalna = wartoscSentymentalna;

        }
    }



    






    class Zabawka
    {
        private double szybkosc;
        private double wysokosc;
        private double glebokosc;
        private double wiek;

        Wartosc wartoscBazowa;



        public Zabawka(double szybkosc,double wysokosc,double glebokosc,Wartosc wartoscBazowa,double wiek)
        {
            this.szybkosc = szybkosc;
            this.wysokosc = wysokosc;
            this.glebokosc = glebokosc;
            this.wartoscBazowa = wartoscBazowa;
            this.wiek = wiek;
        }


        public double Szybkosc
        {
            get
            {
                return this.szybkosc;
            }

            set
            {
                this.szybkosc = value;
            }

        }


        public double Wysokosc
        {
            get
            {
                return this.wysokosc;
            }

            set
            {
                this.wysokosc = value;
            }
        }


        public double Glebokosc
        {
            get
            {
                return this.glebokosc;
            }

            set
            {
                this.glebokosc = value;
            }
        }

        public double Wiek
        {
            get
            {
                return this.wiek;
            }

            set
            {
                this.wiek = value;
            }
        }


        public double WartoscAktualna
        {
            get
            {
                return wartoscBazowa.Cena * this.wiek + wartoscBazowa.WartoscSentymentalna; 
            }
            
        }
    }
}
