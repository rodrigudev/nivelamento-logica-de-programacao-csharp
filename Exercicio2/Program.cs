using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159, valorRaio, area;
            Console.WriteLine("Digite o valor do Raio de um Círculo:");
            valorRaio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * (Math.Pow(valorRaio, 2));
            Console.WriteLine("Àrea do Círculo: " + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }

}