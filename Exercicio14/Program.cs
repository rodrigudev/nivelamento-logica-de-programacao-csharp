/*
Leia um valor inteiro, em seguida mostre os ímpares de 1 até o valor digitado, um valor por linha, inclusive o valor digitado se ele for impar.
*/

using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro");
            int value = int.Parse(Console.ReadLine());

            for (int i = 1; i <= value; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
