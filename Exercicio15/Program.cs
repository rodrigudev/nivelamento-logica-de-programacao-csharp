using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro que representa a quantidade de valores a serem lidos: ");
            int repeticao = int.Parse(Console.ReadLine());

            int contDentroIntervalo = 0;

            for (int i = 0; i < repeticao; i++)
            {
                Console.Write($"Digite o valor {i + 1}: ");
                int valor = int.Parse(Console.ReadLine());

                if (valor >= 10 && valor <= 20)
                {
                    contDentroIntervalo += 1;
                }
            }
            Console.WriteLine($"Quantidade dentro do intervalor 10 e 20 é: {contDentroIntervalo}");
            Console.WriteLine($"Quantidade fora do intervalo 10 e 20 é: {repeticao - contDentroIntervalo}");
        }
    }
}