//Uri 1020
using System;
using System.Globalization;

namespace Uri1019
{

    class Program
    {
        static void Main(string[] args)
        {

            double dinheiro;
            int quociente, nota, resto, moeda;

            dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resto = (int)(dinheiro * 100.0 + 0.5);

            Console.WriteLine($"NOTAS:");

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} nota(s) de R$ 100.00"); 
            resto = resto % (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} nota(s) de R$ 50.00");
            resto %= (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} nota(s) de R$ 20.00");
            resto %= (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} nota(s) de R$ 10.00");
            resto %= (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} nota(s) de R$ 5.00");
            resto %= (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine($"{quociente} nota(s) de R$ 2.00");
            resto %= (nota * 100);

            /////////////MOEDAS////////////
            
            Console.WriteLine("MOEDAS:");

            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine($"{quociente} moeda(s) de R$ 1.00");
            resto %= moeda;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine($"{quociente} moeda(s) de R$ 0.50");
            resto %= moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine($"{quociente} moeda(s) de R$ 0.25");
            resto %= moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine($"{quociente} moeda(s) de R$ 0.10");
            resto %= moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine($"{quociente} moeda(s) de R$ 0.05");
            resto %= moeda;

            Console.WriteLine($"{resto} moeda(s) de R$ 0.01");
        }
    }
}