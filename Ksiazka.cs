using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Flis
{
    class Ksiazka
    {
        private string tytul;
        private string autor;
        private int rokWydania;
        private int iloscStron;
        private bool czyWypozyczona = false;

        //public string Tytul { get; private set; }
        public string Tytul
        {
            get
            {
                return tytul;
            }
            set
            {
                tytul = value;
            }
        }

        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }

        public int RokWydania
        {
            get
            {
                return rokWydania;
            }
            set
            {
                rokWydania = value;
            }
        }

        public int IloscStron
        {
            get
            {
                return iloscStron;
            }
            set
            {
                if (value > 0)
                    iloscStron = value;
                else
                {
                    Console.WriteLine("Ilość stron nie może być mniejsza niż 0");
                }
            }
        }

        public Ksiazka() { }
        public Ksiazka(string tytul, string autor, int rokWydania, int iloscStron)
        { 
            this.tytul = tytul;
            this.autor = autor;
            if (rokWydania > DateTime.Now.Year)
            {
                Console.WriteLine("Ksiązka {0} zly rok", tytul);
            }
            else
            {
                this.rokWydania = rokWydania;
            }

            if (iloscStron <= 0)
            {
                Console.WriteLine("Ksiazka {0} nie moze miec mniej niz 0 stron", tytul);
            }
            else
            {
                this.iloscStron = iloscStron;
            }
            czyWypozyczona = false;
        }

        public void Wypozycz()
        {
            czyWypozyczona = true;
        }

        public void ZwrotKsiazki()
        {
            czyWypozyczona = false;
        }

        public override string ToString()
        {
            string wypozyczenie;
            if (czyWypozyczona == true)
            {
                wypozyczenie = "Wypozyczona";
            }
            else
            {
                wypozyczenie = "Na stanie";
            }

            string szczegolyKsiazki = string.Format("Ksiazka {0}, autora {1}, {2}, Ilosc Stron: {3}", tytul, autor, wypozyczenie, iloscStron);
            return szczegolyKsiazki;
        }
    }
}
