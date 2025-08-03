using System;
using System.Globalization;

namespace ExerciciosMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 07

            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(s[j]);
                }
            }

            int g = int.Parse(Console.ReadLine()) - 1;

            int ult = a[g, n - 1];
            for (int j = n - 1; j > 0; j--)
            {
                a[g, 0] = a[g, j - 1];
            }

            a[g, 0] = ult;

            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

/*
           //Exercicio 06

           int n = int.Parse(Console.ReadLine());

           double[,] mat = new double[n, n];

           for (int i = 0; i < n; i++)
           {
               string[] s = Console.ReadLine().Split(' ');

               for (int j = 0; j < n; j++)
               {
                   mat[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
               }
           }

           double soma = 0.0;

           for (int i = 0;i < n; i++)
           {
               for (int j = 0;j < n; j++)
               {
                   if (mat[i, j] > 0.0)
                   {
                       soma += mat[i, j];
                   }
               }
           }

           Console.WriteLine($"SOMA DOS POSITIVOS: {soma.ToString("F1", CultureInfo.InvariantCulture)}");

           int linha = int.Parse(Console.ReadLine());
           Console.Write("LINHA ESCOLHIDA: ");

           for (int i = 0; i < n; i++)
           {
               for (int j = 0; j < n; j++)
               {
                   if (i == linha)
                   {
                       Console.Write($"{mat[i, j].ToString("F1", CultureInfo.InvariantCulture)} ");
                   }
               }
           }

           Console.WriteLine();

           int coluna = int.Parse(Console.ReadLine());
           Console.Write("COLUNA ESCOLHIDA: ");

           for (int i = 0; i < n ; i++)
           {
               for (int j = 0; j < n ; j++)
               {
                   if (j == coluna)
                   {
                       Console.Write($"{mat[i, j].ToString("F1", CultureInfo.InvariantCulture)} ");
                   }
               }
           }
           Console.WriteLine();

           Console.Write("DIAGONAL PRINCIPAL: ");

           for (int i = 0; i < n; i++)
           {
               Console.Write($"{mat[i, i].ToString("F1", CultureInfo.InvariantCulture)} ");
           }
           Console.WriteLine();

           Console.WriteLine("MATRIZ ALTERADA: ");

           for(int i = 0;i < n; i++)
           {
               for(int j = 0;j < n ; j++)
               {
                   if (mat[i, j] < 0)
                   {
                       mat[i, j] = Math.Pow(mat[i, j], 2);
                   }
               }
           }

           for (int i = 0; i < n; i++)
           {
               for (int j = 0; j < n ; j++)
               {
                   Console.Write($"{mat[i, j].ToString("F1", CultureInfo.InvariantCulture)} ");
               }
               Console.WriteLine();
           }
           */

/*
           // Exercicio 05

           string[] s = Console.ReadLine().Split(' ');

           int m = int.Parse(s[0]);
           int n = int.Parse(s[1]);

           int[,] a = new int[m, n];
           int[,] b = new int[m, n];
           int[,] c = new int[m, n];

           for (int i = 0; i < m; i++)
           {
               s = Console.ReadLine().Split(' ');

               for (int j = 0; j < n; j++)
               {
                   a[i, j] = int.Parse(s[j]);
               }
           }

           for (int i = 0; i < m; i++)
           {
               s = Console.ReadLine().Split(' ');

               for (int j = 0; j < n; j++)
               {
                   b[i, j] = int.Parse(s[j]);
               }
           }

           for (int i = 0; i < m; i++)
           {
               for (int j = 0; j < n; j++)
               {
                   c[i, j] = a[i, j] + b[i, j];
               }
           }

           for (int i = 0; i < m; i++)
           {
               for (int j = 0; j < n; j++)
               {
                   Console.Write($"{c[i, j]} ");
               }
               Console.WriteLine();
           }
           */

/*
            // Exercicio 04

            int n = int.Parse(Console.ReadLine());

            int[,] mat;

            mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int soma = 0;

            for (int i = 0;i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    soma += mat[i, j];
                }
            }

            Console.WriteLine(soma);
            */

/*
            // Exercicio 03

            int n = int.Parse(Console.ReadLine());

            int[,] mat;

            mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                int maior = mat[i, 0];

                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] >= maior)
                    {
                        maior = mat[i, j];
                    }
                }
                Console.WriteLine(maior);
            }
            */

/*
            // Exercicio 02

            int n = int.Parse(Console.ReadLine());

            int[,] mat;

            mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0;i < n; i++)
            {
                int soma = 0;

                for (int j = 0;j < n; j++)
                {
                    soma += mat[i, j];
                }
                Console.WriteLine(soma);
            }
            */

/*
            // Exercicio 01

            string[] s = Console.ReadLine().Split(' ');

            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]);

            int[,] mat;

            mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                s = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(s[j]);
                }
            }

            for (int i = 0;i < m; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.WriteLine($"{mat[i, j]}");
                    }
                }
            }
            */