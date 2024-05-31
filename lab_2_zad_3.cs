using System;

namespace ZadaniaNaStudia
{
    class Lab_2_zad_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar tablicy w przedziale od 10 do 20!");

            int rozmiarTablicy;

            while (true)
            {
                try
                {
                    rozmiarTablicy = Convert.ToInt16(Console.ReadLine());

                    if (10 <= rozmiarTablicy && rozmiarTablicy <= 20) break;
                    else
                    {
                        Console.WriteLine("Podana wartość nie mieści się w danym zakresie, spróbuj ponowanie!");
                    }
                } catch (Exception)
                {
                    Console.WriteLine("Coś poszło nie tak! Spróbuj podać jeszcze raz.");
                }
            }

            int[] liczby = new int[rozmiarTablicy];
            Random random = new Random();

            for (int index = 0; index < rozmiarTablicy; index++)
            {
                liczby[index] = random.Next(1, 21);
            }


            Array.Sort(liczby);

            Console.WriteLine("Oto liczby posortowane rosnąco:");

            foreach (int liczba in liczby)
            {
                Console.Write(liczba + " ");
            }
        }
    }
}