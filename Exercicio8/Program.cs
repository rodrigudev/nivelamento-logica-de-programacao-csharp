//Enunciado 
/*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro*/
using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite hora inicial espaço e hora final:");
            string[] time = Console.ReadLine().Split(' ');

            int duration;
            int startTime = int.Parse(time[0]);
            int endTime = int.Parse(time[1]);

            if (startTime > 12 || endTime == 0)
            {
                duration = (24 - startTime) + endTime;
            }
            else
            {
                duration = endTime - startTime;
            }
            Console.WriteLine($"O tempo foi de: {duration} horas");
        }
    }
}