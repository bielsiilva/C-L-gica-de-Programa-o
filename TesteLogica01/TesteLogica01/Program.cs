using System.Globalization;

namespace TesteLogica01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 06: Estrutura Repetitiva (For)

            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    a++;
                }
                else
                {
                    b++;
                }
            }

            Console.WriteLine($"{a} in");
            Console.WriteLine($"{b} out");
        }
    }
}

/*
           // Exercicio 05: Estrutura Repetitiva (While)
           int x = 2002;

           int senha = int.Parse(Console.ReadLine());

           while (senha != x)
           {
               Console.WriteLine("Senha Inválida");
               senha = int.Parse(Console.ReadLine());
           }

           Console.WriteLine("Acesso Permitido");
           */

/*
            // Exercicio 04: Estrutura Condicional (If Else)

            string[] s = Console.ReadLine().Split(' ');

            double a = double.Parse(s[0], CultureInfo.InvariantCulture);
            double b = double.Parse(s[1], CultureInfo.InvariantCulture);
            double c = double.Parse(s[2], CultureInfo.InvariantCulture);

            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Impossível calcular.");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"X1 = {x1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"X2 = {x2.ToString("F5", CultureInfo.InvariantCulture)}");
            }    
            */

/*
            // Exercicio 03: Estrutura Condicional (Switch Case)
            double total;

            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);    

            switch (a)
            {
                case 1:
                    total = 4.00 * b;
                    Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 2:
                    total = 4.50 * b;
                    Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 3:
                    total = 5.00 * b;
                    Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 4:
                    total = 2.00 * b;
                    Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 5:
                    total = 1.50 * b;
                    Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                default:
                    Console.WriteLine("Inválido");
                    break;
            }
            */

/*
            // Exercicio 02: Estrutura Sequencial

            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * Math.Pow(r, 2);

            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
            */

/*
            // Exercicio 01: Estrutura Sequencial

            string[] s = Console.ReadLine().Split(' ');

            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            double c = double.Parse(s[2], CultureInfo.InvariantCulture);

            string[] j = Console.ReadLine().Split(' ');

            int d = int.Parse(j[0]);
            int e = int.Parse(j[1]);
            double f = double.Parse(j[2], CultureInfo.InvariantCulture);

            double total = b * c + e * f;

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
            */