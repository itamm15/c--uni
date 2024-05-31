using System;

namespace ZadaniaNaStudia
{
    class Lab_2_zad_1
    {
        static void Main(string[] args)
        {
            int[] pierwszaTablica = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int[] drugaTablica = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            bool czyJestWTablicy = false;
            int brakujacyElement = -1;

            foreach (int element in pierwszaTablica) {
                czyJestWTablicy = false;
                foreach (int elementZDrugiej in drugaTablica)
                {
                    if (element == elementZDrugiej)
                    {
                        czyJestWTablicy = true;
                        break;
                    }
                }

                if (!czyJestWTablicy) brakujacyElement = element;
            }

            Console.WriteLine($"Znalazłem brakujący element, jest nim {brakujacyElement}!");
        }
    }
}