using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_Flis
{
    class BibliotekaManager
    {
        List<Ksiazka> ksiazkiLista = new List<Ksiazka>();

        public BibliotekaManager()
        {
            ksiazkiLista.Add(new Ksiazka("Harry Potter", "JK", 2000, 500));
            ksiazkiLista.Add(new Ksiazka("ZA", "JK", 2002, 500));
            ksiazkiLista.Add(new Ksiazka("B.F", "JK", 2000, 500));
        }

        public void Dodaj()
        {
            Ksiazka ksiazka = new Ksiazka();
            Console.WriteLine("Podaj tytuł");
            ksiazka.Tytul = Console.ReadLine();
            Console.WriteLine("Podaj autora");
            ksiazka.Autor = Console.ReadLine();
            Console.WriteLine("Podaj rok wydania");
            ksiazka.RokWydania = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj ilosc stron");
            ksiazka.IloscStron = Convert.ToInt32(Console.ReadLine());

            ksiazkiLista.Add(ksiazka);
            //Console.Clear();
            Console.WriteLine("Dodano ksiażkę");
        }

        public void UsunPoNazwie()
        {
            Ksiazka ksiazkaDoUsuniecia = new Ksiazka();
            Console.WriteLine("Podaj nazwe ksiazki, ktora chcesz usunac:");
            string nazwa = Console.ReadLine();
            foreach (Ksiazka ksiazka in ksiazkiLista)
            {
                if (ksiazka.Tytul == nazwa)
                {
                    ksiazkaDoUsuniecia = ksiazka;
                    break;
                }
            }
            ksiazkiLista.Remove(ksiazkaDoUsuniecia);
        }

        public void Wyswietl()
        {   
            if (ksiazkiLista.Count == 0)
            {
                Console.WriteLine("BRAK KSIAZEK");
            }
            else
            {
                foreach (Ksiazka ksiazka in ksiazkiLista)
                {
                    Console.WriteLine(ksiazka.ToString());

                }
            }
        }

        public void UsunWszystkieKsiazki()
        {
            ksiazkiLista.Clear();
            Console.WriteLine("Ksiazka zostala usunieta");

        }

        public void WyswietlKsiazkiPoRoku()
        {
            Console.WriteLine("Podaj rok wydania ksiazki");
            int RokWydania = Convert.ToInt32(Console.ReadLine());
            foreach (Ksiazka ksiazka in ksiazkiLista)
            {
                if (ksiazka.RokWydania > RokWydania)
                {
                    Console.WriteLine(ksiazka.ToString());
                }
            }
        }
    }

}
