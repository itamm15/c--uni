using System;

namespace ZadaniaNaStudia
{
    class Lab_3_zad_2
    {
        public class Kalkulator
        {
            static List<String> historiaOperacji = new List<String>();

            public static int Dodaj(params int[] liczby)
            {
                try
                {
                    int wynikDodawania = 0;

                    for (int index = 0; index < liczby.Length; index++)
                    {
                        wynikDodawania += liczby[index];
                    }

                    historiaOperacji.Add($"dodawanie - {wynikDodawania}");

                    return wynikDodawania;
                } catch (Exception)
                {
                    Console.WriteLine("Coś poszło nie tak podczas dodawania, spróbuj ponownie!");
                    return 0;
                }
            }

            public static int Odejmowanie(params int[] liczby)
            {
                try
                {
                    if (liczby.Length == 0) throw new Exception("Nie udało się nic odjąć, nic nie zostało podane!");

                    int wynikOdejmowania = liczby[0];
                    for (int index = 1; index < liczby.Length; index ++)
                    {
                        wynikOdejmowania -= liczby[index];
                    }

                    historiaOperacji.Add($"odejmowanie - {wynikOdejmowania}");

                    return wynikOdejmowania;
                } catch (Exception)
                {
                    Console.WriteLine("Coś poszło nie tak podczas odejmowania, spróbuj ponownie!");
                    return 0;
                }
            }

            public static int Mnozenie(params int[] liczby)
            {
                try
                {
                    if (liczby.Length == 0) throw new Exception("Nie udało się nic pomnożyć, nic nie zostało podane!");

                    int wynikMnozenia = 1;
                    for (int index = 0; index < liczby.Length; index++)
                    {
                        wynikMnozenia *= liczby[index];
                    }

                    historiaOperacji.Add($"mnozenie - {wynikMnozenia}");

                    return wynikMnozenia;
                }
                catch (Exception)
                {
                    Console.WriteLine("Coś poszło nie tak podczas mnozenia, spróbuj ponownie!");
                    return 0;
                }
            }

            public static int Dzielenie(params int[] liczby)
            {
                try
                {
                    if (liczby.Length == 0) throw new Exception("Nie udało się nic podzielić, nic nie zostało podane!");

                    int wynikDzielenia = liczby[0];
                    for (int index = 1; index < liczby.Length; index++)
                    {
                        if (liczby[index] == 0) throw new DivideByZeroException("Błąd: Dzielenie przez zero!");
                        wynikDzielenia /= liczby[index];
                    }

                    historiaOperacji.Add($"dzielenie - {wynikDzielenia}");
                    return wynikDzielenia;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
                catch (Exception)
                {
                    Console.WriteLine("Coś poszło nie tak podczas dzielenia, spróbuj ponownie!");
                    return 0;
                }
            }

            public static void PokazHistorie()
            {
                if (historiaOperacji.Count == 0 )
                {
                    Console.WriteLine("Nie ma żadnych operacji w historii!");
                } else
                {
                    Console.WriteLine("Historia operacji:");
                    for (int index = 0; index < historiaOperacji.Count; index++)
                    {
                        Console.WriteLine(historiaOperacji.ElementAt(index));
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Kalkulator.PokazHistorie();

            Kalkulator.Dodaj(1, 2, 3, 4, 5);
            Kalkulator.PokazHistorie();
            Kalkulator.Odejmowanie(10, 2, 3);
            Kalkulator.Mnozenie(1, -2, 3, -4, 5);
            Kalkulator.Dzielenie(100, 2, 5);
            Kalkulator.PokazHistorie();
        }
    }
}