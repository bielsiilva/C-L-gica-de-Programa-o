using System;
using System.Globalization;

namespace ExerciciosCondicional02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                x = x + 1;
            }

            Console.WriteLine(x);
            Console.WriteLine(x + 2);
            Console.WriteLine(x + 4);
            Console.WriteLine(x + 6);
            Console.WriteLine(x + 8);
            Console.WriteLine(x + 10);
        }
    }
}

/*
 * Exercicio 1050: DDD
           int ddd = int.Parse(Console.ReadLine());

           switch(ddd)
           {
               case 61:
                   Console.WriteLine("Brasilia");
                   break;
               case 71:
                   Console.WriteLine("Salvador");
                   break;
               case 11:
                   Console.WriteLine("Sao Paulo");
                   break;
               case 21:
                   Console.WriteLine("Rio de Janeiro");
                   break;
               case 32:
                   Console.WriteLine("Juiz de Fora");
                   break;
               case 19:
                   Console.WriteLine("Campinas");
                   break;
               case 27:
                   Console.WriteLine("Vitoria");
                   break;
               case 31:
                   Console.WriteLine("Belo Horizonte");
                   break;
               default:
                   Console.WriteLine("DDD nao cadastrado");
                   break;
           }
           */

/*
             * 
             * Exercicio 1042: Triangulo
            double perimetro, area;

            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (a < b + c && b < a + c && c < a + b)
            {
                perimetro = a + b + c;
                Console.WriteLine($"Perimetro = {perimetro.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                area = (a + b) * c / 2;
                Console.WriteLine($"Area = {area.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            */