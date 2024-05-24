using System;
namespace ZadaniaNaStudia
{
    class Lab_1_zad_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoją masę w kilogramach");
            double masaCiala = GetMasaCiala();

            Console.WriteLine("Podaj swój wzrost w metrach");
            double wzrost = GetWzrost();

            double BMI = BMICalculator(masaCiala, wzrost);

            if (BMI < 16) Console.WriteLine("Twoje BMI wskazuje na wygłodzenie.");
            else if (BMI >= 16 && BMI <= 16.99) Console.WriteLine("Twoje BMI wskazuje na wychudzenie");
            else if(BMI >= 17 && BMI <= 18.49) Console.WriteLine("Twoje BMI wskazuje na niedowagę");
            else if(BMI >= 18.50 && BMI <= 24.99) Console.WriteLine("Twoje BMI wskazuje wartość prawidłową");
            else if (BMI >= 25.00 && BMI <= 29.99) Console.WriteLine("Twoje BMI wskazuje na nadwagę");
            else if (BMI >= 30.00 && BMI <= 34.99) Console.WriteLine("Twoje BMI wskazuje na I stopień otyłości");
            else if (BMI >= 35.00 && BMI <= 39.99) Console.WriteLine("Twoje BMI wskazuje na II stopień otyłości");
            else if (BMI > 40) Console.WriteLine("Twoje BMI wskazuje na skrajną otyłość");
        }

        private static double GetMasaCiala()
        {
            while (true)
            {
                try
                {
                    // umozliwij podawanie z `,` zamiast `.`
                    string masaCialaString = Console.ReadLine().Replace(',', '.');
                    double masaCiala = Convert.ToDouble(masaCialaString);

                    if (masaCiala > 0)
                    {
                        return masaCiala;
                    } else
                    {
                        Console.WriteLine("Masa ciała musi być większa od zera, spróbuj ponowanie!");
                    }
                } catch (Exception exception)
                {
                    Console.WriteLine("Niepoprawna masa ciała, spróbuj ponowanie!");
                }
            }
        }

        private static double GetWzrost()
        {
            while (true)
            {
                try
                {
                    // umozliwij podawanie z `,` zamiast `.`
                    string wzrostString = Console.ReadLine().Replace(',', '.');
                    double wzrost = Convert.ToDouble(wzrostString);
                    
                    if (wzrost > 0)
                    {
                        return wzrost;
                    } else
                    {
                        Console.WriteLine("Wzrost musi być większy od zera, spróbuj ponownie!");
                    }
                } catch (Exception exception)
                {
                    Console.WriteLine("Niepoprawny wzrost, spróbuj ponowanie");
                }
            }
        }


        private static double BMICalculator(double masaCiala, double wzrost)
        {
            try
            {
                return masaCiala / (wzrost * wzrost);
            } catch (Exception exception)
            {
                Console.WriteLine($"Ups, cos poszlo nie tak! Spróbuj jeszcze raz od początku. {exception}");
                Environment.Exit(1);
                return 0;
            }
        }
    }
}

