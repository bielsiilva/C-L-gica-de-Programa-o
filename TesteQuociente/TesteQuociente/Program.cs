using System;
using System.Globalization;

namespace TesteQuociente
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
             * Fórmula de Bhaskara
            double a, b, c, delta, r1, r2;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine($"R1 = {r1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {r2.ToString("F5", CultureInfo.InvariantCulture)}");
            }
            */
            /*
             * Menor número
            int x, y, z;

            string[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0], CultureInfo.InvariantCulture);
            y = int.Parse(vet[1], CultureInfo.InvariantCulture);
            z = int.Parse(vet[2], CultureInfo.InvariantCulture);

            if (x < y && x < z)
            {
                Console.WriteLine($"MENOR = {x}");
            }
            else if (y < z) {
                Console.WriteLine($"MENOR = {y}");
            }
            else
            {
                Console.WriteLine($"MENOR = {z}");
            }
            */
            /*
             * Atribuição Cumulativa
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;

            if (minutos > 100)
            {
                conta += (minutos - 100) * 2.0;
            }

            Console.WriteLine($"Valor a pagar: R$ {conta.ToString("F2", CultureInfo.InvariantCulture)}");
            */
            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x)
            {
                case 1:
                    dia = "domingo";
                    break;
                case 2:
                    dia = "segunda";
                    break;
                case 3:
                    dia = "terça";
                    break;
                case 4:
                    dia = "quarta";
                    break;
                case 5:
                    dia = "quinta";
                    break;
                case 6:
                    dia = "sexta";
                    break;
                case 7:
                    dia = "sabado";
                    break;
                default:
                    dia = "valor invalido";
                    break;
            }


;        }
    }
}
