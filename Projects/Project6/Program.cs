using System;
using System.Globalization;
using Project6.Entities;
using Project6.Entities.Enums;


namespace Project6 {
    class Program {

        static void Main(string[] args) {

            Console.Write($"Enter department1s name: ");
            Department deptName = new Department(Console.ReadLine()); // Primeiro instancia o departamento e depois o worker associado passando o departamento instanciado.

            Console.WriteLine($"Enter worker data: ");
            Console.Write($"Name: ");
            string name = Console.ReadLine();

            Console.Write($"Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()); //Converte string para o tipo enum.

            Console.Write($"Base salary: ");
            double baseSalary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);



            Worker w1 = new Worker(name, level, baseSalary, deptName); // Depois de instanciar o tipo department e converter string para enum é possível realizar a isntanciação do objeto worker. 

            Console.Write($"How many contracts to this worker? ");
            int contracts = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= contracts; i++) {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write($"Date (DD/MM/YYYY): ");
                DateTime d1 = Convert.ToDateTime(Console.ReadLine());
                Console.Write($"Value per hour: ");
                double valuePerHour1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write($"Duration (hours): ");
                int hour = Convert.ToInt32(Console.ReadLine());

                HourContract contract1 = new HourContract(d1, valuePerHour1, hour); //O objeto contract1 só existe dentro do escopo do for

                w1.AddContract(contract1); // Mas o contrato permanece válido fora do escopo do for porque ele está sendo adicionado ao atributo Contracts que e uma lista que já existe fora do for.

            }


            Console.Write($"Enter month and year to calculate income (MM/YYYY): ");
            DateTime d4 = Convert.ToDateTime(Console.ReadLine());
            double income = w1.Income(d4.Year, d4.Month);
            Console.WriteLine($"Name: {w1.Name}");
            Console.WriteLine($"Department: {w1.Department.Name}"); //Objeto worker acessando o seu atributo Department que por sua vez está acessando o seu atributo Name.
            Console.WriteLine($"Income for {d4.Month}/{d4.Year}: ${income.ToString("F2", CultureInfo.InvariantCulture)}");  
        }
    }
}
