using System;

class URI
{

    static void Main(string[] args)
    {

        int x, y;
        string[] vet;

         vet = Console.ReadLine().Split(' ');

        x = int.Parse(vet[0]);
        y = int.Parse(vet[1]);


        while (x >= 0.1 && y >= 0.1)
        {
            Console.WriteLine("primeiro");
             vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
        }

        while (x >= 0.1 && y <= -0.1)
        {
            Console.WriteLine("quarto");
            vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
        }

        while (x <= -0.1 && y <= -0.1)
        {
            Console.WriteLine("terceiro");
            vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
        }

        while (x <= -0.1 && y >= 0.1)
        {
            Console.WriteLine("segundo");
            vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
        }

        }

}