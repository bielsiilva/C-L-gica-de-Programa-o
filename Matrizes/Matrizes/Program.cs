namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 2

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
                    mat[i, j] = int.Parse(s[j]);
                }
            }
            int[] vet = new int[m];

            for (int i = 0;i < m; i++)
            {
                int soma = 0;

                for (int j = 0;j < n; j++)
                {
                    soma += mat[i, j];
                }

                vet[i] = soma;
            }

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}

/*
           // Exercicio 1
           int n = int.Parse(Console.ReadLine());

           int[,] a;

           a = new int[n, n];

           for (int i = 0; i < n; i++)
           {
               string[] s = Console.ReadLine().Split(' ');
               for (int j = 0; j < n; j++)
               {
                   a[i, j] = int.Parse(s[j]);
               }
           }

           Console.WriteLine("DIAGONAL PRINCIPAL:");
           for (int i = 0;i < n; i++)
           {
               Console.Write($"{a[i, i]} ");
           }

           Console.WriteLine();

           int cont = 0;

           for (int i = 0; i < n; i++) 
           {
               for (int j = 0; j < n; j++)
               {
                   if (a[i, j] < 0)
                   {
                       cont++;
                   }
               }
           }

           Console.WriteLine($"QUANTIDADE DE NEGATIVOS = {cont}");
           */

/*
            // Conceito em explicação passo a passo sobre matrizes.
            int m, n;
            int[,] a;

            string[] s1 = Console.ReadLine().Split(' ');
            m = int.Parse(s1[0]);
            n = int.Parse(s1[1]);

            a = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < m; i++) 
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
            */