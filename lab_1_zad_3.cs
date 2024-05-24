using System;

namespace ZadaniaNaStudia
{
    class Lab_1_zad_3
    {
        static void Main(string[] args)
        {
            decimal najmniejsza = 0, najwieksza = 0;
            bool flag = true;

            for (int index = 0; index < 5; index++)
            {
                flag = true;
                Console.WriteLine($"Podaj {index + 1} liczbę");
                while (flag)
                {
                    try
                    {
                        decimal liczba = Convert.ToDecimal(Console.ReadLine());

                        if (index == 0)
                        {
                            najmniejsza = liczba;
                            najwieksza = liczba;
                            flag = false;
                        }
                        else
                        {
                            // sprawdz czy podana jest wieksza od poprzedniej
                            if (liczba > najwieksza) najwieksza = liczba;
                            if (liczba < najmniejsza) najmniejsza = liczba;
                            flag = false;
                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine($"Nie udało się odczytać liczby, spróbuj ponownie podać {index + 1} liczbę!");
                    }
                }
            }


            Console.WriteLine($"Największa liczba spośród podanych wynosi: {najwieksza}");
            Console.WriteLine($"Najmniejsza liczba spośród podanych wynosi: {najmniejsza}");
        }
    }
}

