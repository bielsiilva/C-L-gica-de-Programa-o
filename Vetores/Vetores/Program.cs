using System;
using System.Globalization;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // Estrutura Foreach
           int n;

           n = int.Parse(Console.ReadLine());

           string[] vet = new string[n];

           for (int i = 0; i < n; i++)
           {
               vet[i] = Console.ReadLine();
           }

           Console.WriteLine("Nomes lidos: ");

           foreach (string elemento in vet)
           {
               Console.WriteLine(elemento);
           }
        }
    }
}

/*
           // Estrutura For
           int n;

           n = int.Parse(Console.ReadLine());

           string[] vet = new string[n];

           for (int i = 0; i < n; i++)
           {
               vet[i] = Console.ReadLine();
           }

           Console.WriteLine("Nomes lidos: ");

           for (int i = 0;i < n; i++)
           {
               Console.WriteLine(vet[i]);
           }
           */

/*
            //  Exemplo 2
            int n;
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idade = new int[n];
            double[] altura = new double[n];

            // Leitura dos dados

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);
                altura[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
             }

            // Cálculo da idade média

            double soma = 0.0;
            
            for (int i = 0;i < n; i++)
            {
                soma += altura[i];
            }

            double media = soma / n;

            Console.WriteLine($"Altura média: {media.ToString("F2", CultureInfo.InvariantCulture)}");

            // Porcentagem de pessoas abaixo de 16 anos

            int cont = 0;

            for (int i = 0; i < n; i++)
            {
                if (idade[i] < 16) 
                {
                    cont++;
                }
            }

            double porcentagem = (double) cont / n * 100.0;

            Console.WriteLine($"Pessoas com menos de 16 anos: {porcentagem.ToString("F1", CultureInfo.InvariantCulture)}%");
            */

/*
            // Exemplo 1
            int n;
            double[] a;

            n = int.Parse(Console.ReadLine());
            a = new double[n];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                a[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i].ToString("F1", CultureInfo.InvariantCulture)} ");
            }

            double soma = 0.0;

            for (int i = 0;i < n; i++)
            {
                soma += a[i];
            }

            double media = soma / n;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            */

/*
           int n;
           double[] vet;

           n = int.Parse(Console.ReadLine());
           vet = new double[n];

           for (int i = 0; i < n; i++)
           {
               vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           }

           for (int i = 0; i < n; i++)
           {
               Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
           }

           */
