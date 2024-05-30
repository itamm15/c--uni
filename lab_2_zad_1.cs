using System;

namespace ZadaniaNaStudia
{
    class Lab_2_zad_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę wierszy macierzy");
            int liczbaWierszy = GetRozmiar();

            Console.WriteLine("Podaj liczbę kolumn macierzy");
            int liczbaKolumn = GetRozmiar();

            decimal[,] pierwszaMacierz = new decimal[liczbaWierszy, liczbaKolumn];
            decimal[,] drugaMacierz = new decimal[liczbaWierszy, liczbaKolumn];

            Console.WriteLine("Uzupełnij pierwszą macierz");

            for (int wiersze = 0; wiersze < liczbaWierszy; wiersze++)
            {
                for (int kolumny = 0; kolumny < liczbaKolumn; kolumny++)
                {
                    Console.WriteLine($"Podaj wartość [{wiersze}][{kolumny}]");
                    while (true)
                    {
                        try
                        {
                            decimal index = Convert.ToDecimal(Console.ReadLine());
                            pierwszaMacierz[wiersze, kolumny] = index;
                            break;
                        } catch (Exception)
                        {
                            Console.WriteLine("Niepoprawna wartość, spróbuj jeszcze raz");
                        }
                    }
                }
            }

            Console.WriteLine("Uzupełnij drugą macierz");

            for (int wiersze = 0; wiersze < liczbaWierszy; wiersze++)
            {
                for (int kolumny = 0; kolumny < liczbaKolumn; kolumny++)
                {
                    Console.WriteLine($"Podaj wartość [{wiersze}][{kolumny}]");
                    while (true)
                    {
                        try
                        {
                            decimal index = Convert.ToDecimal(Console.ReadLine());
                            drugaMacierz[wiersze, kolumny] = index;
                            break;

                        } catch (Exception)
                        {
                            Console.WriteLine("Niepoprawna wartość, spróbuj jeszcze raz");
                        }
                    }
                }
            }

            // Dodawanie macierzy
            decimal[,] dodaneMacierze = new decimal[liczbaWierszy, liczbaKolumn];

            for (int wiersze = 0; wiersze < liczbaWierszy; wiersze++)
            {
                for (int kolumny = 0; kolumny < liczbaKolumn; kolumny++)
                {
                    dodaneMacierze[wiersze, kolumny] = pierwszaMacierz[wiersze, kolumny] + drugaMacierz[wiersze, kolumny];
                }
            }

            // Wyswietl dodane macierze:

            Console.WriteLine("Wynik dodawnia dwóch macierzy:");

            for (int wiersze = 0; wiersze < liczbaWierszy; wiersze++)
            {
                for (int kolumny = 0; kolumny < liczbaKolumn; kolumny++)
                {
                    Console.Write(dodaneMacierze[wiersze, kolumny] + "\t");
                }
                Console.WriteLine("");
            }

        }

        private static int GetRozmiar()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Coś poszło nie tak podczas podawania wymiary, spróbuj jeszcze raz!");
                }
            }
        }
    }
}