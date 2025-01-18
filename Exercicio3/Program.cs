using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, valor4, diferenca;
            Console.WriteLine("Digite 4 valores Inteiros:");
            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());
            valor3 = int.Parse(Console.ReadLine());
            valor4 = int.Parse(Console.ReadLine());

            diferenca = (valor1 * valor2) - (valor3 * valor4);

            Console.WriteLine("A Diferença: " + diferenca);


        }
    }
}

