using System;
using System.Globalization;

namespace ExerciciosCondicional01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            float n1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            float n2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            float n3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            float n4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            float media = (n1 * 2 + n2 * 3 + n3 * 3 + n4 * 1) / 10;

            Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");

                float notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Nota do exame: {notaExame.ToString("F1", CultureInfo.InvariantCulture)}");

                float mediaFinal = (media + notaExame) / 2;

                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine($"Media final: {mediaFinal.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
