//Uri 1015
using System;
using System.Globalization;

namespace programa
{

    class Uri
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, distancia;

            string[] linha1 = Console.ReadLine().Split(' ');

            x1 = double.Parse(linha1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(linha1[1], CultureInfo.InvariantCulture);


            string[] linha2 = Console.ReadLine().Split(' ');

            x2 = double.Parse(linha2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(linha2[1], CultureInfo.InvariantCulture);


            distancia = Math.Sqrt (Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        } 
    }
}