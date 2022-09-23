using System;

namespace programa
{
    class batatinha
    {
        static void Main(string[] args)
        {
            int x, resto, n;

            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                n = int.Parse(Console.ReadLine());

                resto = n % 2;

                if (resto == 0 && n > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }

                else if (resto == 0 && n < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }

                else if (resto == 1 && n > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }

                else if (resto == -1)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }

                else if (n == 0)
                {
                    Console.WriteLine("NULL");
                }
            }

        }

    }
}