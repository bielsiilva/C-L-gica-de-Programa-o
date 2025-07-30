
using System;
using System.Formats.Asn1;
using System.Globalization;

namespace TesteCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Utilizando o Split para colocar variáveis conforme digitadas com espaço.
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = Char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            Lendo areas e comprimentos.
            double larg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double cm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double metro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = larg * cm;
            double preco = area * metro;

            Console.WriteLine($"AREA: {area.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PREÇO: {preco.ToString("F2", CultureInfo.InvariantCulture)}");
            */
            /*
            int a, b, x;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            x = a + b;

            Console.WriteLine(x);
            */
            /*
            double r; double pi = 3.14159; double area;

            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * (r * r);

            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
            */
            /*
            int number; int hours; double value; double salary;

            number = int.Parse(Console.ReadLine());
            hours = int.Parse(Console.ReadLine());
            value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = hours * value;

            Console.WriteLine($"NUMBER = {number}");
            Console.WriteLine($"SALARY = {salary.ToString("F2", CultureInfo.InvariantCulture)}");
            */
            /*
            double triangulo, circulo, trapezio, quadrado, retangulo;

            string[] vet = Console.ReadLine().Split(' ');

            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            triangulo = a * c / 2.0;
            circulo = 3.14159 * c * c;
            trapezio = ((a + b) 2.0 * c;
            quadrado = b * b;
            retangulo = a * b;

            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            */
        }
    }
}
