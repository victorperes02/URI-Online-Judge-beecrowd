using System;


namespace programa
{
    class batatinha
    {
        static void Main(string[] args)
        {

            int x, n;
            int dentro = 0;
            int fora = 0;

            x = int.Parse(Console.ReadLine());


            for (int i = 0; i < x; i++)
            {
                n = int.Parse(Console.ReadLine());
                if (n >= 10 && n <= 20)
                {
                    dentro++;
                }
                else if (n < 10 || n > 20)
                {
                    fora++;
                }
            }
            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}
