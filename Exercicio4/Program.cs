using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int codEmployee, amountHoursWorked;
            double amountReceiverPerHours, salary;

            Console.WriteLine("Digite seu número:");
            codEmployee = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantidade de horas trabalhadas:");
            amountHoursWorked = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor que recebe por hora:");
            amountReceiverPerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = amountHoursWorked * amountReceiverPerHours;
            Console.WriteLine("Funcionário Número: " + codEmployee);
            Console.WriteLine("Salario = U$" + salary.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}