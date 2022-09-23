//Uri 1048
using System;
using System.Globalization;

namespace Uri1048
{

    class Program
    {
        static void Main(string[] args)
        {

            double salario, reajuste, percentual;

            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (salario <= 400)
            {
                percentual = 15;
                reajuste = salario * (percentual/100);
                salario += reajuste;
            }
            else if (salario >= 400.01 && salario <= 800)
            {
                percentual = 12;
                reajuste = salario * (percentual/100);
                salario += reajuste;
            }
            else if (salario >= 800.01 && salario <= 1200)
            {
                percentual = 10;
                reajuste = salario * (percentual/100);
                salario += reajuste;
            }
            else if (salario >= 1200.01 && salario <= 2000)
            {
                percentual = 7;
                reajuste = salario * (percentual/100);
                salario += reajuste;
            }
            else
            {
                percentual = 4;
                reajuste = salario * (percentual/100);
                salario += reajuste;

            }

            Console.WriteLine($"Novo salario: {salario.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Em percentual: {percentual} %");
        }
    }
}