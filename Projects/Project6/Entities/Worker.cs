using Project6.Entities.Enums;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Project6.Entities {
    internal class Worker {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // Um trabalhador só tem um departamento, então só foi preciso adicionar como atributo.
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // Um trabalhor tem vários contratos por isso tem que ser uma lista.

        public Worker (string name, WorkerLevel level, double baseSalary, Department department) {

            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void addContract(HourContract hourContract) {


        }

    }
}
