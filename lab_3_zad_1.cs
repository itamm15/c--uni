using System;

namespace ZadaniaNaStudia
{
    class Lab_3_zad_1
    {
        public class Student
        {
            private int indentyfikator;
            private String nazwisko;
            // W tym zadaniu dopuszczam jako oceny tylko liczby calkowite,
            // czyli: 1, 2, 3, 4, 5, 6 - inne liczby (w tym polowki) sa niepoprawne
            private List<int> listaOcen = new List<int>();

            public Student(int indentyfikator, String nazwisko, List<int> listaOcen)
            {
                try
                {
                    foreach (int ocena in listaOcen)
                    {
                        if (ocena >= 1 && ocena <= 6) continue;
                        else throw new Exception("Niepoprawna liczba!");
                    }

                    this.indentyfikator = indentyfikator;
                    this.nazwisko = nazwisko;
                    this.listaOcen = listaOcen;
                } catch (Exception)
                {
                    Console.WriteLine("Coś poszło nie tak z tworzeniem studenta, spróbuj ponowanie!");
                }
            }

            public void addOcena(int ocena)
            {
                if (ocena >= 1 && ocena <= 6)
                {
                    listaOcen.Add(ocena);
                    Console.WriteLine("Dodane ocenę!");
                } else
                {
                    Console.WriteLine("Podana wartosc jest nie mieści się w kryterium ocen, spróbuj ponownie!");
                }
            }

            public int getOcena(int index)
            {
                try
                {
                    return listaOcen.ElementAt(index);
                } catch (Exception) {
                    Console.WriteLine("Ups, nie udało się znaleźć liczby w liście, spróbuj ponowanie z innym indeksem!");
                    return -1;
                }
            }
        }

        static void Main(string[] args)
        {
            Student student = new Student(1, "Osinski", new List<int> { 1, 2, 3, 4, 6 });
            Student student1 = new Student(1, "Osinski", new List<int> { 1, 2, 3, 4, 2 });

            student.addOcena(5);
            student.addOcena(1);

            int ocena = student.getOcena(1);
            int ocena2 = student.getOcena(5);
            int ocena3 = student.getOcena(10);

            Console.WriteLine($"Dodane oceny dla studenta: {ocena} {ocena2} {ocena3}");

            student1.addOcena(2);
            student1.addOcena(-1);

            int ocena4 = student1.getOcena(0);
            Console.WriteLine($"Dodane oceny dla studenta1: {ocena4}");
        }
    }
}