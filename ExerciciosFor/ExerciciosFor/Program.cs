using System;
using System.Globalization;

namespace ExerciciosFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  URI 1165
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                int y = int.Parse(Console.ReadLine());
                int metade = y / 2;

                bool primo = true;

                for (int j = 2; j <= metade; j++)
                {
                    if (y % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                {
                    Console.WriteLine($"{y} eh primo");
                }
                else
                {
                    Console.WriteLine($"{y} nao eh primo");
                }
            }
        }
    }
}

/* URI 1158
           int n = int.Parse(Console.ReadLine());

           int x, y;

           for (int i = 0; i < n; i++)
           {
               string[] vet = Console.ReadLine().Split(' ');
               x = int.Parse(vet[0]);
               y = int.Parse(vet[1]);

               if (x % 2 == 0)
               {
                   x++;
               }

               int soma = 0;

               for (int j = 0; j < y; j++)
               {
                   soma += x;
                   x += 2;
               }

               Console.WriteLine(soma);
           }
           */

/*
           // URI 1150
           int x = int.Parse(Console.ReadLine());

           int z = 0;

           do
           {
               z = int.Parse(Console.ReadLine());
           }
           while (z <= x);

           int soma = 0, cont = 0, atual = x;

           while (soma <= z)
           {
               soma += atual;
               atual++;
               cont++;
           }

           Console.WriteLine(cont);
           */

/*
            //URI 1149

            int i, soma, a, n;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);

            i = 1;

            n = int.Parse(vet[i]);

            while (n <= 0)
            {
                i += 1;
                n = int.Parse(vet[i]);
            }

            soma = 0;

            for (i = 0; i < n; i++)
            {
                soma += a + i;
            }

            Console.WriteLine(soma);
            */

/* URI 1145
            int x, y;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            for (int i = 1; i <= y; i++)
            {
                Console.Write($"{i}");
                
                if (i % x == 0 || i == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
            */

/*
           // URI 1101
           int m, n;

           do
           {
               int min, max, soma = 0;

               string[] vet = Console.ReadLine().Split(' ');
               m = int.Parse(vet[0]);
               n = int.Parse(vet[1]);

               if (m <= 0 || n <= 0)
               {
                   break;
               }

               if (m > n)
               {
                   min = n;
                   max = m;
               }
               else
               {
                   min = m;
                   max = n;
               }

               for (int i = min; i <= max; i++)
               {
                   Console.Write($"{i} ");
                   soma += i;
               }

               Console.WriteLine($"Sum={soma}");

           }
           while (m != 0 && m > 0 || n != 0 && n > 0);

          */

/*
           // URI 1099
           int n = int.Parse(Console.ReadLine());

           int x, y;

           int min, max;

           for (int i = 0; i < n; i++)
           { 
               string[] vet = Console.ReadLine().Split(' ');
               x = int.Parse(vet[0]);
               y = int.Parse(vet[1]);

               if (x > y)
               {
                   max = x;
                   min = y + 1;
               }
               else
               {
                   min = x + 1;
                   max = y;
               }

               int cont = 0;

               for (int j = min; j < max; j++)
               {
                   if (j % 2 != 0)
                   {
                       cont += j;
                   }
               }

               Console.WriteLine(cont);
           }
           */

/*
           // URI 1157

           int x = int.Parse(Console.ReadLine());

           for (int i = 1; i <= x; i++)
           {
               if (x % i == 0)
               {
                   Console.WriteLine(i);
               }
           }
           */

/* URI 1156
            double s = 0.0;
            int numerador = 1, denominador = 1;
            

            for (int i = 1; i <= 20; i++)
            {
                s += (double) numerador / denominador;

                numerador += 2;
                denominador *= 2;
            }

            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
            */

/* URI 1155
           double s = 0.0;

           for (int i = 1; i <= 100; i++)
           {
               s += 1.0 / i;
           } 

           Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
           */

/*
           // URI 1153
           int x = int.Parse(Console.ReadLine());
           int y = 1;

           for (int i = 1; i <= x; i++)
           {
               y *= i;
           }

           Console.WriteLine($"{y}");
           */

/*
            // URI 1151 FIBUNACCI
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i = i + 1)
            {
                if (i == n - 1)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.Write(a + " ");
                }
                int aux = b;
                b = a;
                a = aux + b;
            }
            */

/*
            // URI 1144
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} {i * i} {i * i * i}");
                Console.WriteLine($"{i} {i * i + 1} {i * i * i + 1}");
            }
            */

/*
           // URI 1143 / 1142
           int n = int.Parse(Console.ReadLine());

           int x = 1;

           for (int i = 0; i < n; i++)
           {
               int segundo = x * x;
               int terceiro = x * x * x;

               Console.WriteLine($"{x} {segundo} {terceiro}");

               x += 1;
           }
           */

/*
             * URI 1133
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                int aux = x;
                x = y;
                y = aux;
            }

            for (int i = x + 1; i < y; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine($"{i}");
                }
            }  
            */

/*
            // URI 1132
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int min = x;
            int max = y;

            if (x > y)
            {
                min = y;
                max = x;
            }

            int soma = 0;

            for (int i = min; i <= max; i++)
            {
                if (i % 13 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine($"{soma}");
            */

/*
            // URI 1116
            double total;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    total = (double) x / y;
                    Console.WriteLine($"{total.ToString("F1", CultureInfo.InvariantCulture)}");
                }
            }
            */

/*
            // URI 1097
            int j = 7;
            for (int i = 1; i <= 9; i += 2)
            {
                Console.WriteLine("I=" + i + " J=" + j);
                Console.WriteLine("I=" + i + " J=" + (j - 1));
                Console.WriteLine("I=" + i + " J=" + (j - 2));
                j += 2;
            }
            */

/*
            // URI 1096
            for (int i = 1; i <= 9; i++)
            {
                int j = 7;

                while (j != 4)
                {         
                    Console.WriteLine($"I={i} J={j}");
                    j -= 1;
                }

                i += 1;
            }

            */
/*
           // URI 1094
           int x, total;

           int c = 0, r = 0, s = 0;

           double cperc, rperc, sperc;

           x = int.Parse(Console.ReadLine());

           for (int i = 0; i < x; i++)
           {
               string[] vet = Console.ReadLine().Split(' ');
               int quantia = int.Parse(vet[0]);
               char tipo = char.Parse(vet[1]);

               if (tipo == 'C')
               {
                   c += quantia;
               }
               else if (tipo == 'R')
               {
                   r += quantia;
               }
               else if (tipo == 'S')
               {
                   s += quantia;
               }
           }

           total = c + r + s;

           cperc = (double) c / total * 100.0;
           rperc = (double) r / total * 100.0;
           sperc = (double) s / total * 100.0;

           Console.WriteLine($"Total: {total} cobaias");
           Console.WriteLine($"Total de coelhos: {c}");
           Console.WriteLine($"Total de ratos: {r}");
           Console.WriteLine($"Total de sapos: {s}");
           Console.WriteLine($"Percentual de coelhos: {cperc.ToString("F2", CultureInfo.InvariantCulture)} %");
           Console.WriteLine($"Percentual de ratos: {rperc.ToString("F2", CultureInfo.InvariantCulture)} %");
           Console.WriteLine($"Percentual de sapos: {sperc.ToString("F2", CultureInfo.InvariantCulture)} %");
           */

/*
            // URI 1080
            int y = 0;
            int cont = 0;

           for (int i = 1; i <= 100;  i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x >= y)
                {
                    y = x;
                    cont = i;
                }
            }

            Console.WriteLine(y);
            Console.WriteLine(cont);
            */

/*
           // uri 1079
           int x;
           double a, b, c, media;

           x = int.Parse(Console.ReadLine());

           for (int i = 0; i < x; i++) {
               string[] vet = Console.ReadLine().Split(' ');
               a = double.Parse(vet[0], CultureInfo.InvariantCulture);
               b = double.Parse(vet[1], CultureInfo.InvariantCulture);
               c = double.Parse(vet[2], CultureInfo.InvariantCulture);

               media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
               Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
           }
           */

/*
            // URI 1075
            int x;

            x = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10000; i++) {
                if (i % x == 2)
                {
                    Console.WriteLine(i);
                }
            }
            */

/*
            // URI 1074
            int x, y;

            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                y = int.Parse(Console.ReadLine());

                if (y > 0 && y % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (y < 0 && y % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (y > 0 && y % 2 != 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (y < 0 && y % 2 != 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else
                {
                    Console.WriteLine("NULL");
                }
            }
            */

/*
            // URI 1073
            int x, total; 

            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    total = i * i;

                    Console.WriteLine($"{i}^2 = {total}");
                }
            }
            */

/*
            // URI 1072
            int x, y, cont1 = 0, cont2 = 0;

            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                y = int .Parse(Console.ReadLine());

                if (y >= 10 && y <= 20)
                {
                    cont1++;
                }
                else
                {
                    cont2++;
                }
            }

            Console.WriteLine($"{cont1} in");
            Console.WriteLine($"{cont2} out");
            */

/*          URI 1067
            int x;

            x = int.Parse(Console.ReadLine());

            for (int i = 1; i < x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }                
            }
            */