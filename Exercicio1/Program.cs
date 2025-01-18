using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorUm, valorDois, valorDaSoma;

            Console.WriteLine("Digite o Valor 1");
            valorUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor 2");
            valorDois = int.Parse(Console.ReadLine());
            valorDaSoma = valorUm + valorDois;
            Console.WriteLine("Valor da Soma: " + valorDaSoma);
        }
    }

}

