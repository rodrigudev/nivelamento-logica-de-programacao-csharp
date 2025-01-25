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

            int maxValue = 0, minValue = 0;
            double multiplication, division;

            if (valueOne >= valueTwo && valueOne >= valueThree)
            {
                maxValue = valueOne;

                if (valueTwo >= valueThree)
                {
                    minValue = valueThree;
                }
                else
                {
                    minValue = valueTwo;
                }
            }
            else if (valueTwo >= valueThree && valueTwo >= valueOne)
            {
                maxValue = valueTwo;

                if (valueThree >= valueOne)
                {
                    minValue = valueOne;
                }
                else
                {
                    minValue = valueThree;
                }
            }
            else if (valueThree >= valueOne && valueThree >= valueTwo)
            {
                maxValue = valueThree;

                if (valueOne >= valueTwo)
                {
                    minValue = valueTwo;
                }
                else
                {
                    minValue = valueOne;
                }
            }
            multiplication = minValue * maxValue;
            division = maxValue / minValue;
            Console.WriteLine($"A Multiplicação entre menor valor e o maior é: {multiplication:F2}");
            Console.WriteLine($"A Divisão entre maior valor e o menor é: {division:F2}");


        }
    }
}