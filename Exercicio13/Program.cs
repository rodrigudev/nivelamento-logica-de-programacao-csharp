/*
Escreva um programa que peça números ao usuário até que ele insira o número 0. Ao final, exiba a soma de todos os números digitados.
*/
using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number;

            do
            {
                Console.WriteLine("Digite um valor:");
                number = int.Parse(Console.ReadLine());

                if (number != 0)
                {
                    sum += number;
                }

            } while (number != 0);

            Console.WriteLine($"A soma dos números digitados é: {sum}");

        }
    }
}