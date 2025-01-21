// Verificação se são valores multiplos
using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagem;

            Console.WriteLine("Digite primeiro valor inteiro");
            int valueOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite segundo valor inteiro");
            int valueTwo = int.Parse(Console.ReadLine());

            if (valueOne % valueTwo == 0 || valueTwo % valueOne == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não São Multiplos");
            }

        }
    }
}