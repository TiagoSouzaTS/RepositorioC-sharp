using Project6.Entities.Enums;
using System.Collections.Generic;


namespace Project6.Entities {
    internal class Worker {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // Um trabalhador só tem um departamento, então só foi preciso adicionar como atributo.
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // Um trabalhor tem vários contratos por isso tem que ser uma lista.

        public Worker() {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract) {

            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract) {

            Contracts.Remove(contract);
        }

        public double Income(int year, int month) {

            double sum = BaseSalary;
            foreach(HourContract contract in Contracts) {

                if (contract.Date.Year == year && contract.Date.Month == month) {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
        
    }
}
