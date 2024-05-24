using System;

namespace ZadaniaNaStudia
{
    class Lab_1_zad_1
    {
        // oprocentowanie w skali rocznej
        const decimal oprocentowanieKredytu = 0.05m;
        const decimal minimalnaKwota = 10000;
        const decimal maksymalnaKwota = 100000;
        const int minimalnaIloscRat = 6;
        const int maksymalnaIloscRat = 96;

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj kwotę kredytu (zakres 10000PLN - 100000PLN)");

            decimal kwotaKredytu = GetKwotaKredytu();

            Console.WriteLine("Podaje ilość rat (zakres 6-96rat)");

            int iloscRat = GetIloscRat();
            
            decimal roczneOdestki = kwotaKredytu * oprocentowanieKredytu;
            decimal miesieczneOdsetki = roczneOdestki / 12.0m;
            decimal rataMiesieczna = (kwotaKredytu / iloscRat) + miesieczneOdsetki;
            decimal calkowityKoszt = rataMiesieczna * iloscRat;

            Console.WriteLine($"""
                Kwota kredytu: {kwotaKredytu} PLN {'\n'}
                Liczba rat: {iloscRat} {'\n'}
                Miesięczna rata: {rataMiesieczna:F2} {'\n'}
                Całkowita kwota: {calkowityKoszt:F2}
                """);
        }

        private static decimal GetKwotaKredytu()
        {
            while (true)
            {
                try
                {
                    decimal kwotaKredytu = Convert.ToDecimal(Console.ReadLine());
                    if (kwotaKredytu >= minimalnaKwota && kwotaKredytu <= maksymalnaKwota)
                    {
                        return kwotaKredytu;
                    } else
                    {
                        Console.WriteLine($"Kwota kredytu musi być w zakresie od {minimalnaKwota} do {maksymalnaKwota} PLN. Spróbuj ponownie.");
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Niepoprawna kwota! Spróbuj ponownie.");
                }
            }
        }

        private static int GetIloscRat()
        {
            while(true)
            {
                try
                {
                    int iloscRat = Convert.ToInt32(Console.ReadLine());
                    if (iloscRat >= minimalnaIloscRat && iloscRat <= maksymalnaIloscRat)
                    {
                        return iloscRat;
                    } else
                    {
                        Console.WriteLine($"Ilość rat musi być w zakresie od {minimalnaIloscRat} do {maksymalnaIloscRat}. Spróbuj ponownie.");
                    }

                }
                catch (Exception exception)
                {
                    Console.WriteLine("Niepoprawna ilość rat! Spróbuj ponownie.");
                }
            }
        }
    }
}