//Uri 1019
using System;

namespace Uri1019
{

    class Program
    { 
        static void Main(string[] args)
        {
            int horas, minutos, segundos, resto;

            segundos = int.Parse(Console.ReadLine());

            horas = segundos / 3600;

            resto = segundos % 3600;

            minutos = resto / 60;

            segundos %= 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}