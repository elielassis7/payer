using System;
using System.Collections.Generic;
using Payer.Entities;


namespace Payer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payers> payers = new List<Payers>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpen = double.Parse(Console.ReadLine());
                    payers.Add(new Individual(name, anualIncome, healthExpen));
                }
                else if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    payers.Add(new Company(name, anualIncome, employees));
                }
                else
                {
                    Console.WriteLine("Invalid!");
                    i--;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Taxes paid: ");
            double sum = 0;
            foreach (Payers item in payers)
            {
                Console.WriteLine(item.Name + ": $ " + item.Taxes().ToString("F2"));
                sum += item.Taxes();

            }

            
            Console.WriteLine();
            
            Console.WriteLine("Total Taxes: $ " + sum);
        }
    }
}
