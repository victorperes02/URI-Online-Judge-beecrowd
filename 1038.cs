//Uri 1038
using System;
using System.Globalization;

namespace Uri1038
{

    class Program
    {
        static void Main(string[] args)
        {

            int codigo, quantidade;
            double preco;
            string[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            if (codigo == 1)
            {
                preco = quantidade * 4.00;
            }
            else if (codigo == 2)
            {
                preco = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                preco = quantidade * 5.00;
            }
            else if (codigo == 4)
            {
                preco = quantidade * 2.00;
            }
            else
            {
                preco = quantidade * 1.50;
            }

            Console.WriteLine($"Total: R$ {preco.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}