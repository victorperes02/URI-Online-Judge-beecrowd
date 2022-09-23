using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int idade;
        double idademedia;
        int cont = 0;
        int soma = 0;
        idade = int.Parse(Console.ReadLine());

        while (idade >0)
        {
            cont += 1;
            soma += idade;
            idade = int.Parse(Console.ReadLine());
        }

        idademedia = (double) soma / cont;
        Console.WriteLine(idademedia.ToString("F2",CultureInfo.InvariantCulture));

    }

}