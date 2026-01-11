using System;
using System.Collections.Generic;

namespace TeatrRezerwacje
{
    public class Seat
    {
        public int Rzad { get; set; }
        public int Numer { get; set; }
        public int Koszt { get; set; }
        public int UserId { get; set; }

        public Seat(int rzad, int numer)
        {
            Rzad = rzad;
            Numer = numer;
            Koszt = (rzad <= 3) ? 120 : 80;
            UserId = 0;
        }
    }

    class Program
    {
        static List<Seat> sala = new List<Seat>();

        static void Main(string[] args)
        {
            for (int r = 1; r <= 6; r++)
            {
                for (int m = 1; m <= 10; m++)
                {
                    sala.Add(new Seat(r, m));
                }
            }

            string uzytkownik = " Paweł Nawrocki";
            int uzytkownikId = 1;
            int sumaDoZaplaty = 0;

            bool koniec = false;
            while (!koniec)
            {
                Console.WriteLine($"\nZalogowany: {uzytkownik}");
                Console.WriteLine("1. Pokaz sale | 2. Rezerwuj | 3. Zaplac i wyjdz");
                Console.Write("Wybor: ");
                string wybor = Console.ReadLine();

                if (wybor == "1")
                {
                    WyswietlSale();
                }
                else if (wybor == "2")
                {
                    Console.Write("Podaj rzad: ");
                    int r = int.Parse(Console.ReadLine());
                    Console.Write("Podaj numer: ");
                    int n = int.Parse(Console.ReadLine());

                    Seat znalezione = sala.Find(s => s.Rzad == r && s.Numer == n);

                    if (znalezione != null && znalezione.UserId == 0)
                    {
                        znalezione.UserId = uzytkownikId;
                        sumaDoZaplaty += znalezione.Koszt;
                        Console.WriteLine($"Zarezerwowano! Cena: {znalezione.Koszt} zl");
                    }
                    else
                    {
                        Console.WriteLine("Miejsce zajete lub nie istnieje");
                    }
                }
                else if (wybor == "3")
                {
                    Console.WriteLine($"Do zaplaty: {sumaDoZaplaty} zl. Dziekujemy!");
                    koniec = true;
                }
            }

            Console.WriteLine("\n--- Wszystkie rezerwacje w systemie ---");
            foreach (var s in sala)
            {
                if (s.UserId != 0)
                {
                    Console.WriteLine($"Rzad {s.Rzad}, Miejsce {s.Numer} - Uzytkownik ID: {s.UserId}");
                }
            }
        }

        static void WyswietlSale()
        {
            Console.WriteLine("\nPlan sali ([o] wolne, [x] zajete):");
            for (int r = 1; r <= 6; r++)
            {
                Console.Write($"{r}: ");
                for (int m = 1; m <= 10; m++)
                {
                    Seat s = sala.Find(x => x.Rzad == r && x.Numer == m);
                    Console.Write(s.UserId == 0 ? "[o] " : "[x] ");
                }
                Console.WriteLine();
            }
        }
    }
}