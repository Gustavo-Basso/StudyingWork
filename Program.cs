using System;
using WorkerPayment.Entities;

namespace WorkerPayment {

    internal class Program {
    
    
        static void Main(string[] args) {


            Console.WriteLine("Enter department name: ");
            string dp = Console.ReadLine();
            Console.WriteLine("Worker data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("How many contracts: ");
            int n = int.Parse(Console.ReadLine());
            Department a = new Department(dp);
            Worker work = new Worker(name, baseSalary);
            
            for (int i = 1; i <= n; i ++) {

                Console.WriteLine($"Enter contract {i} data:");
                Console.WriteLine("Date: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value Per hour");
                double value = double.Parse(Console.ReadLine());
                Console.WriteLine("Duration (hours) ");
                int hour = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, value, hour);
                work.AddContract(contract);

            }

            Console.WriteLine("Month/Year income: ");
            string incomeDate = Console.ReadLine();
            int month = int.Parse(incomeDate.Substring(0, 2));
            int year = int.Parse(incomeDate.Substring(3));
            work.Income(month, year);
            Console.WriteLine("Department: " + a);
            Console.WriteLine("Worker name: " + work.Name);
            Console.WriteLine("Total income: " + work.Income(month, year));



        }
    
    
    }



}