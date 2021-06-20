using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Biblioteka_Flis
{
    class Program
    {
        static void Main(string[] args)
        {
            BibliotekaManager bibliotekaManager = new BibliotekaManager();

            while (true)
            {
                Console.WriteLine("1. Dodaj książkę");
                Console.WriteLine("2. Wyswietl Wszystkie Ksiazki");
                Console.WriteLine("3. Usun ksiazke (po nazwie)");
                Console.WriteLine("4. Usun wszystkie ksiazki");
                Console.WriteLine("5. Wyswietl Po Roku");
                Console.WriteLine("6. Wyjście");

                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();

                if (key.Key == ConsoleKey.D1)
                {
                    bibliotekaManager.Dodaj();
                }
                else if (key.Key == ConsoleKey.D2)
                {
                    bibliotekaManager.Wyswietl();
                    Console.WriteLine("2");
                }
                else if (key.Key == ConsoleKey.D3)
                {
                    bibliotekaManager.UsunPoNazwie();
                    Console.WriteLine("3");
                }
                else if (key.Key == ConsoleKey.D4)
                {
                    bibliotekaManager.UsunWszystkieKsiazki();
                    Console.WriteLine("4");
                }
                else if (key.Key ==ConsoleKey.D5)
                {
                    bibliotekaManager.WyswietlKsiazkiPoRoku();
                    Console.WriteLine("5");
                }
                else if (key.Key == ConsoleKey.D6)
                {
                    Environment.Exit(0);
                }

                //Console.ReadKey();
            }

        }
    }
}
