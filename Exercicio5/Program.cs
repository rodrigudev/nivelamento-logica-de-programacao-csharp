using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para verificar:");
            int numero = int.Parse(Console.ReadLine());
            string mensagem = (numero >= 0) ? "Positivo" : "Negativo";
            Console.WriteLine($"O número é: {mensagem}");

        }
    }
}
