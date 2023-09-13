using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerPayment.Entities.Enum;

namespace WorkerPayment.Entities {
    internal class Worker {

        public String  Name { get; set; }
        public Double BaseSalary{ get; set; }
        public WorkerLevel Level { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Hours { get; set; } = new List<HourContract>();



        public Worker(string name, double baseSalary ) { 
            
            Name = name;
            BaseSalary = baseSalary;

        }

        public void AddContract(HourContract contract) { 
            
            Hours.Add(contract);

        
        }

        public void RemoveContract(HourContract contract) {
                
            Hours.Remove(contract);
        }

        public double Income(int month, int year) {

            double sum = 0;

            foreach (HourContract contract in Hours) {

                if (contract.Date.Month == month && contract.Date.Year == year) {

                    sum += contract.TotalValor();

                }
                
            }
            return sum + BaseSalary;

        }
        

       
        
    }
}
