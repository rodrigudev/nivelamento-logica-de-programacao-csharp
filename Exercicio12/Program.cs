/*
Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). Usar somente estrutura Repetitiva While
*/
using System;


namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as cordenadas na mesma linha separadas por espaço");
            string[] cordenadas = Console.ReadLine().Split(' ');

            int corX = int.Parse(cordenadas[0]);
            int corY = int.Parse(cordenadas[1]);

            while (corX != 0 && corY != 0)
            {
                if (corX > 0 && corY > 0)
                {
                    Console.WriteLine("Primeiro Quadrante");
                }
                else if (corX < 0 && corY > 0)
                {
                    Console.WriteLine("Segundo Quadrante");
                }
                else if (corX < 0 && corY < 0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else if (corX > 0 && corY < 0)
                {
                    Console.WriteLine("Quarto Quadrante");
                }

                Console.WriteLine("Digite as cordenadas");
                cordenadas = Console.ReadLine().Split(' ');

                corX = int.Parse(cordenadas[0]);
                corY = int.Parse(cordenadas[1]);

            }
        }
    }
}