using System;

namespace programa
{
    class batatinha
    {
        static void Main(string[] args)
        {
            int x, resto;

            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                resto = i % x;

                if (resto == 2)
                    Console.WriteLine(i);
            }

        }

    }
}