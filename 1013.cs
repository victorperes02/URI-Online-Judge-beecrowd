using System;


namespace programa
{
    class Uri
    {
        static void Main(string[] args)
        {

            int a, b, s, maior1, maior2;

            a = int.Parse(Console.ReadLine());

            b = int.Parse(Console.ReadLine());

            s = int.Parse(Console.ReadLine());

            maior1 = (a + b + Math.Abs(a - b)) / 2;

            maior2 = (maior1 + s + Math.Abs(maior1 - s)) / 2;


            Console.WriteLine($"{maior2} eh o maior");

              Console.ReadKey();
        }
    }
}