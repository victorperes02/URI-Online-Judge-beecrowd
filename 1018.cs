//Uri 1018
using System;

namespace Uri1018
{

    class Program
    { 
        static void Main(string[] args)
        {
            int dinheiro, nota, resto, quociente;

            dinheiro = int.Parse(Console.ReadLine());

            resto = dinheiro;

            Console.WriteLine(dinheiro);

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 50;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 1;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
        }
    }
}

