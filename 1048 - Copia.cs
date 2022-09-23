//Uri 1048
using System;
using System.Globalization;

namespace Uri1048
{

    class Program
    {
        static void Main(string[] args)
        {
            double entrada, intervalo;

            entrada = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (entrada >= 0 && entrada <= 25.0000)
            {
                intervalo =  0.25;
            }
            else if (entrada >= 25.0001 && entrada <= 50.0000)
            {
                intervalo = 25.50;
            }
            else if (entrada >= 50.0001 && entrada <= 75.0000)
            {
                intervalo = 50.75;
            }
            else if (entrada >= 75.0001 && entrada <= 100.000)
            {
                intervalo = 75.100;

            }
            else
            {
                intervalo = 0;
                Console.WriteLine("Fora de intervalo");
            }

            Console.WriteLine($"Intervalo {intervalo.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}