using System;
using System.Linq;

namespace ZadaniaNaStudia
{
    class Lab_3_zad_3
    {
        public class Samochod
        {
            private double przebieg { get; set; }
            private List<(double przebieg, double paliwo)> tankowania;

            public Samochod()
            {
                przebieg = 0;
                tankowania = new List<(double, double)>();
            }

            public void Tankowanie(double paliwo, double aktualnyPrzebieg)
            {
                if (aktualnyPrzebieg < przebieg)
                {
                    Console.WriteLine("Błąd: Aktualny przebieg nie może być mniejszy niż poprzedni. (kilometry)");
                    return;
                }

                if (paliwo <= 0)
                {
                    Console.WriteLine("Błąd: Ilość paliwa musi być większa niż 0. (litry)");
                    return;
                }

                this.przebieg = aktualnyPrzebieg;
                this.tankowania.Add((aktualnyPrzebieg, paliwo));
                Console.WriteLine($"Zatankowano {paliwo} litrów paliwa przy przebiegu {aktualnyPrzebieg} km.");
            }

            public double SrednieSpalanie()
            {
                // sprawdz ile bylo tankowan
                if (tankowania.Count < 1)
                {
                    Console.WriteLine("Auto nie było jeszcze tankowane, nie mogę wykonać obliczeń!");
                    return 0;
                }
                if (tankowania.Count == 1)
                {
                    double przebieg = tankowania.ElementAt(0).przebieg;
                    double paliwo = tankowania.ElementAt(0).paliwo;
                    return (przebieg / paliwo);
                }

                double calkowitePaliwo = 0;
                double calkowityPrzebieg = 0;

                for (int i = 1; i < tankowania.Count; i++)
                {
                    calkowitePaliwo += tankowania[i].paliwo;
                    calkowityPrzebieg += tankowania[i].przebieg - tankowania[i - 1].przebieg;
                }

                return (calkowitePaliwo / calkowityPrzebieg);
            }
        }
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod();

            samochod.Tankowanie(50, 100);
            Console.WriteLine($"Średnie spalanie wynosi: {samochod.SrednieSpalanie()}");
            samochod.Tankowanie(30, 200);
            samochod.Tankowanie(10, 240);
            samochod.Tankowanie(60, 500);
            Console.WriteLine($"Średnie spalanie wynosi: {samochod.SrednieSpalanie()}");
        }
    }
}