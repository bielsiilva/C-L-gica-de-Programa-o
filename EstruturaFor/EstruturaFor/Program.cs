using System;
using System.Globalization;

namespace EstruturaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, min, max, soma = 0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine($"{soma}");
        }
    }
}

/*
            int valor, total;

            valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                total = i * valor;

                Console.WriteLine($"{i} x {valor} = {total}");
            }
            */

/*
            int soma = 0, i;
            int x = int.Parse(Console.ReadLine());

            for (i = 0; i < x; i++)
            {
                int y = int.Parse(Console.ReadLine());
                soma += y;
            }

            Console.WriteLine($"{soma}");
            */
