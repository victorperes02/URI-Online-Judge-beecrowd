//Uri 1048
using System;
using System.Globalization;

namespace Uri1048
{

    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, exame, media, mediaex;

            string[] vet = Console.ReadLine().Split(' ');

            n1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1 ) /10;


            //Média Sem Exame Aprovado
            if (media >= 7)
            {
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aluno aprovado.");
            }
            //Média Sem Exame Aprovado
           else if (media < 5 )
            {
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                mediaex = (media + exame) / 2;
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine($"Nota do exame: {exame.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Aluno aprovado.");
                Console.WriteLine($"Media final: {mediaex.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            Console.ReadLine();
        }
    }
}