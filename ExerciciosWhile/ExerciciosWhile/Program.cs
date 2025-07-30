using System;
using System.Globalization;

namespace ExerciciosWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* URI 1131 */
            int opcao = 1, cont = 0, time1 = 0, time2 = 0, empate = 0, x, y;

            while (opcao == 1)
            {

                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (x > y)
                {
                    time1++;
                }
                else if (y > x)
                {
                    time2++;
                }
                else if (x == y)
                {
                    empate++;
                }

                cont++;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());

                while (opcao != 1 && opcao != 2)
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    opcao = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"{cont} grenais");
            Console.WriteLine($"Inter:{time1}");
            Console.WriteLine($"Gremio:{time2}");
            Console.WriteLine($"Empates:{empate}");

            if (time1 > time2)
            {
                Console.WriteLine($"Inter venceu mais");
            }
            else if (time2 > time1)
            {
                Console.WriteLine($"Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}

/*          URI 1118
            int opcao = 1;

            while (opcao == 1)
            {
                double nota1, nota2, media;

                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (nota1 < 0.0 || nota1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (nota2 < 0.0 || nota2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                media = (nota1 + nota2) / 2;

                Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("novo calculo (1-sim 2-nao)");

                opcao = int.Parse(Console.ReadLine());

                while (opcao != 1 && opcao != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    opcao = int.Parse(Console.ReadLine());
                }
            }
            */

/* URI 1159
           int x = int.Parse(Console.ReadLine());

           while (x != 0)
           {
               if (x % 2 != 0)
               {
                   x = x + 1;
               }

               int soma = 5 * x + 20;
               Console.WriteLine(soma);

               x = int.Parse(Console.ReadLine());
           }
           */

/* URI 1154

            int idade, quant = 0, cont = 0;
            double media;

            idade = int.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                if (idade >= 0)
                {
                    quant += idade;
                    cont++;
                }

                idade = int.Parse(Console.ReadLine());
            }

            media =(double) quant / cont;

            Console.WriteLine($"{media.ToString("F2", CultureInfo.InvariantCulture)}");  
            */

/*
           int tipo, cont1 = 0, cont2 = 0, cont3 = 0;

           tipo = int.Parse(Console.ReadLine());

           while (tipo != 4)
           {
               if (tipo == 1)
               {
                   cont1++;
               }
               else if (tipo == 2)
               {
                   cont2++;
               }
               else if (tipo == 3)
               {
                   cont3++;
               }
               else if (tipo == 4)
               {
                   break;
               }

               tipo = int.Parse(Console.ReadLine());
           }

           Console.WriteLine("MUITO OBRIGADO");
           Console.WriteLine($"Alcool: {cont1}");
           Console.WriteLine($"Gasolina: {cont2}");
           Console.WriteLine($"Diesel: {cont3}");
           */

/*
 *         URI 1134 
           double nota1, nota2, media;

           nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           while (nota1 < 0.0 || nota1 > 10.0)
           {
               Console.WriteLine("nota invalida");
               nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           }

           nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           while (nota2 < 0.0 || nota2 > 10.0)
           {
               Console.WriteLine("nota invalida");
               nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           }

           media = (nota1 + nota2) / 2;

           Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
           */
