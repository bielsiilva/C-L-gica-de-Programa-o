using System;
using System.Globalization;

namespace ExerciciosCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, duracao;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            

            if (a < b)
            {
                duracao = b - a;
            }
            else
            {
                duracao = 24 - a + b;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");

        }
    }
}
