using System;
using System.Globalization;

namespace ExerciciosVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 9

            int n = int.Parse(Console.ReadLine());

            string[] produto = new string[n];
            double[] valorCompra = new double[n];
            double[] valorVenda = new double[n];

            double lucroPercentual, lucroTotal, totalCompra = 0.0, totalVenda = 0.0;
            int lucroMenor10 = 0, lucroEntre10e20 = 0, lucroMaior20 = 0;

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                produto[i] = vet[0];
                valorCompra[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
                valorVenda[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);

                lucroPercentual = ((valorVenda[i] - valorCompra[i]) / valorCompra[i]) * 100.0;

                if (lucroPercentual < 10.0)
                {
                    lucroMenor10++;
                }
                else if (lucroPercentual <= 20.0)
                {
                     lucroEntre10e20++;
                }
                else
                {
                    lucroMaior20++;
                }

                totalCompra += valorCompra[i];
                totalVenda += valorVenda[i];
            }
            
            lucroTotal = totalVenda - totalCompra;

            Console.WriteLine($"Lucro abaixo de 10%: {lucroMenor10}");
            Console.WriteLine($"Lucro entre 10% e 20%: {lucroEntre10e20}");
            Console.WriteLine($"Lucro acima de 20%: {lucroMaior20}");
            Console.WriteLine($"Valor total de compra: {totalCompra.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor total de venda: {totalVenda.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Lucro total: {lucroTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

/*
           // Exercicio 8
           int n;
           n = int.Parse(Console.ReadLine());

           double[] altura = new double[n];
           char[] sexo = new char[n];

           // Leitura dos dados

           for (int i = 0; i < n; i++)
           {
               string[] s = Console.ReadLine().Split(' ');

               altura[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
               sexo[i] = char.Parse(s[1]);
           }

           double menor = altura[0];
           double maior = altura[0];
           double media, contF = 0, soma = 0;
           int contM = 0;

           for (int i = 1; i < n; i++)
           {
               if (altura[i] < menor)
               {
                   menor = altura[i];
               }

               if (altura[i] > maior)
               {
                   maior = altura[i];
               }

               if (sexo[i] == 'F')
               {
                   contF++;
               }

               if (sexo[i] == 'F')
               {
                   soma += altura[i];
               }

               if (sexo[i] == 'M')
               {
                   contM++;
               }
           }

           media = soma / contF;

           Console.WriteLine($"Menor altura = {menor.ToString("F2", CultureInfo.InvariantCulture)}");
           Console.WriteLine($"Maior altura = {maior.ToString("F2", CultureInfo.InvariantCulture)}");
           Console.WriteLine($"Media das alturas das mulheres = {media.ToString("F2", CultureInfo.InvariantCulture)}");
           Console.WriteLine($"Numero de homens = {contM}");
           */

/*
           // Exercicio 7
           int n;
           n = int.Parse(Console.ReadLine());

           string[] nome = new string[n];
           double[] nota1 = new double[n];
           double[] nota2 = new double[n];
           double[] media = new double[n];

           // Leitura dos dados

           for (int i = 0; i < n; i++)
           {
               string[] s = Console.ReadLine().Split(' ');

               nome[i] = s[0];
               nota1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
               nota2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
           }

           for (int i = 0; i < n; i++)
           {
               media[i] = (nota1[i] + nota2[i]) / 2.0;

               if (media[i] >= 6.0)
               {
                   Console.WriteLine("Alunos aprovados: ");
                   Console.WriteLine(nome[i]);
               }
           }   
           */

/*
            // Exercicio 6
            int n;
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idade = new int[n];

            // Leitura dos dados

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);
            }

            int maior = idade[0];
            string nomeMaior = nome[0];

            for (int i = 1; i < n; i++)
            {
                if (idade[i] > maior)
                {
                    maior = idade[i];
                    nomeMaior = nome[i];
                }
            }   
            
            Console.WriteLine($"Pessoa mais velha: {nomeMaior}");
            */

/*
           // Exercicio 5

           int n = int.Parse(Console.ReadLine());

           int[] x = new int[n];

           string[] vet = Console.ReadLine().Split(' ');

           for (int i = 0; i < n; i++)
           {
               x[i] = int.Parse(vet[i]);
           }

           double soma = 0.0;
           double quantia = 0.0;

           for (int i = 0; i < n; i++)
           {
               if (x[i] % 2 == 0)
               {
                   soma += x[i];
                   quantia++;
               }
           }

           double media = (double)soma / quantia;

           Console.WriteLine($"{media.ToString("F1", CultureInfo.InvariantCulture)}");
           */

/*
            // Exercicio 4

            int n = int.Parse(Console.ReadLine());

            double[] x = new double[n];

            string[] vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                x[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            for (int i = 0;i < n; i++)
            {
                soma += x[i];
            }

            double media = (double) soma / n;

            Console.WriteLine($"{media.ToString("F3", CultureInfo.InvariantCulture)}");

            foreach (double elemento in x)
            {
                if (elemento < media)
                {
                    Console.WriteLine($"{elemento.ToString("F1", CultureInfo.InvariantCulture)}");
                }
            }
            */

/*
           // Exercicio 3

           int n = int.Parse(Console.ReadLine());

           int[] x = new int[n];
           int[] y = new int[n];
           int[] z = new int[n];

           string[] a = Console.ReadLine().Split(' ');

           for (int i = 0; i < n; i++)
           {
               x[i] = int.Parse(a[i]);
           }

           string[] b = Console.ReadLine().Split(' ');

           for (int i = 0; i < n; i++)
           {
               y[i] = int.Parse(b[i]);
           }

           for (int i = 0; i < n; i++)
           {
               z[i] = x[i] + y[i];
           }

           foreach (int elemento in z)
           {
               Console.Write($"{elemento} ");
           }
           */

/*
           // Exercicio 2

           int n = int.Parse(Console.ReadLine());

           int[] x = new int[n];

           string[] vet = Console.ReadLine().Split(' ');

           for (int i = 0; i < n; i++)
           {
               x[i] = int.Parse(vet[i]);
           }

           int quantidade = 0;

           foreach (int elemento in x)
           {
               if (elemento % 2 == 0)
               {
                   quantidade++;
                   Console.Write($"{elemento} ");
               }
           }

           Console.WriteLine();
           Console.WriteLine(quantidade);
           */

/*
           // Exercicio 01

           int n = int.Parse(Console.ReadLine());

           int[] x = new int[n];

           string[] vet = Console.ReadLine().Split(' ');

           for (int i = 0; i < n; i++)
           {
               x[i] = int.Parse(vet[i]);
           }

           int maior = [0];
           int posicao = 0;

           for (int i = 1; i < n; ++i)
           {
               if (x[i] > maior)
               {
                   maior = x[i];
                   posicao = i;
               }
           }

           Console.WriteLine(maior);
           Console.WriteLine(posicao);
           */
