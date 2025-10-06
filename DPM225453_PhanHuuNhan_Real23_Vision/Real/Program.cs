using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IEmployee> employees = new List<IEmployee>
            {
                new RegularEmployee("Alice", 3000),
                new Manager("Bob", 5000, 2000),
                new Contractor("Charlie", 20, 100)
            };

            var salaryVisitor = new SalaryCalculatorVisitor();
            foreach (var emp in employees)
                emp.Accept(salaryVisitor);
            Console.WriteLine($"Total salary: {salaryVisitor.TotalSalary}");
            Console.WriteLine();

            var taxVisitor = new TaxCalculatorVisitor();
            foreach (var emp in employees)
                emp.Accept(taxVisitor);
            Console.WriteLine($"Total tax: {taxVisitor.TotalTax}");

            Console.ReadKey();
        }
    }
}
