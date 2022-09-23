using System;


namespace programa
{
    class batatinha
    {
        static void Main(string[] args)
        {

            int x, par, somapar;

            x = int.Parse(Console.ReadLine());


            for (int i = 1; i <= x; i++)
            {
                par = i % 2;
                if (par == 0)
                {
                    somapar = (int)Math.Pow(i, 2);
                    Console.WriteLine($"{i}^2 = {somapar}");
                }
            }

        }

    }
}
