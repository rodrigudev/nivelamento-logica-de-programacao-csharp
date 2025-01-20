using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int number = int.Parse(Console.ReadLine());
            string result = (number % 2 == 0) ? "Par" : "Impar";

            Console.WriteLine($"O Número é: {result}");
        }
    }
}