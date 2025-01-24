// Leia 3 variáveis do tipo inteiro, exiba o menor valor lido multiplicado pelo maior e o maior valor dividido pelo menor.
// usar somente estrutura condicional
using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 valores inteiros, separandos pelo espaço");
            string[] values = Console.ReadLine().Split(' ');

            int valueOne = int.Parse(values[0]);
            int valueTwo = int.Parse(values[1]);
            int valueThree = int.Parse(values[2]);

            int maxValue, minValue, multiplication, division;

            if (valueOne >= valueTwo && valueOne >= valueThree)
            {
                if (valueTwo >= valueThree)
                {
                    multiplication = valueThree * valueOne;
                    division = valueOne / valueThree;
                    Console.WriteLine($"A Multiplicação entre menor valor e o maior é: {multiplication}");
                    Console.WriteLine($"A Divisão entre maior valor e o menor é: {division}");
                }
                else
                {
                    multiplication = valueTwo * valueOne;
                    division = valueOne / valueTwo;
                    Console.WriteLine($"A Multiplicação entre menor valor e o maior é: {multiplication}");
                    Console.WriteLine($"A Divisão entre maior valor e o menor é: {division}");
                }
            }
            else if (valueTwo >= valueThree && valueTwo >= valueOne)
            {
                minValue = valueThree;
                multiplication = minValue * valueOne;
                division = valueOne / valueThree;
            }
            else
            {
                minValue = valueTwo;
                multiplication = valueTwo * valueOne;
                division = valueOne / valueTwo;
            }



        }
    }
}