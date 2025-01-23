//leia 3 números inteiros e imprima na tela os valores em ordem decrescente. Usando somente estrutura condicional.
using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite 3 valores inteiros na mesma linha com espaço");
            string[] values = Console.ReadLine().Split(' ');

            int valueOne = int.Parse(values[0]);
            int valueTwo = int.Parse(values[1]);
            int valueThree = int.Parse(values[2]);

            if (valueOne >= valueTwo && valueOne >= valueThree)
            {
                if (valueTwo >= valueThree)
                {
                    Console.WriteLine($"Os valores em ordem Decrescente: {valueOne}, {valueTwo}, {valueThree}");
                }
            }
            else if (valueTwo >= valueOne && valueTwo >= valueThree)
            {
                if (valueOne >= valueThree)
                {
                    Console.WriteLine($"Os valores em ordem Decrescente: {valueTwo}, {valueOne}, {valueThree}");
                }
                else
                {
                    Console.WriteLine($"Os valores em ordem Decrescente: {valueTwo}, {valueThree}, {valueOne}");
                }
            }
            else
            {
                Console.WriteLine($"Os valores em ordem Decrescente: {valueThree}, {valueTwo}, {valueOne}");
            }

        }
    }
}