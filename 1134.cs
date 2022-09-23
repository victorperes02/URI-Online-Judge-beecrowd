using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int valores;

        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;

        valores = int.Parse(Console.ReadLine());

        while (valores >0 && valores != 4)
        {
            if (valores == 1)
            {
                alcool += 1;
            }
            else if (valores == 2)
            {
                gasolina += 1;
            }
            else if (valores == 3)
            {
                diesel += 1;
            }
            valores = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {alcool}");
        Console.WriteLine($"Gasolina: {gasolina}");
        Console.WriteLine($"Diesel: {diesel}");

    }

}