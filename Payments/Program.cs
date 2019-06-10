using System;
using Payments.Enities;
using Payments.Enities.Enums;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Departments Name? ");
            string department = Console.ReadLine();
            Department depart = new Department(department);

            Console.WriteLine("Enter Worker Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            string workerLevel = Console.ReadLine();

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Worker worker = new Worker(name, Enum.Parse<WorkerLevel>(workerLevel), baseSalary, depart);

            Console.Write("How many contracts to this worker? ");
            int qtdContract = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdContract; i++)
            {
                Console.WriteLine("Enter #" + (i + 1) + " contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                worker.Contracts.Add(new HourContract(date, valuePerHour, hours));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string yearMonth = Console.ReadLine();
            string[] elements = yearMonth.Split("/");
            double income = worker.Income(int.Parse(elements[0]), int.Parse(elements[1]));

        }
    }
}
