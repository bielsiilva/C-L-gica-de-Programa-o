using System;
using System.Globalization;

namespace EstruturaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, media;
            int cont;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma = 0.0;
            cont = 0;

            if (idade < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                while (idade >= 0)
                {
                    soma += idade;
                    cont++;
                    idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                media = soma / cont;

                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }

            

        }
    }
}

/*
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);
            
            while (x != y)
            {
                if (x > y)
                {
                    Console.WriteLine("Decrescente");
                }
                else if (x < y)
                {
                    Console.WriteLine("Crescente");
                }

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
            */
