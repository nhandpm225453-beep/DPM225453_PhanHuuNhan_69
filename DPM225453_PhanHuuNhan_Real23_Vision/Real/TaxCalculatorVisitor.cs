using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real
{
    public class TaxCalculatorVisitor : IVisitor
    {
        public double TotalTax { get; private set; } = 0;

        public void Visit(RegularEmployee employee)
        {
            double tax = employee.MonthlySalary * 0.1;
            TotalTax += tax;
            Console.WriteLine($"{employee.Name} (Regular) tax: {tax}");
        }

        public void Visit(Manager manager)
        {
            double tax = (manager.MonthlySalary + manager.Bonus) * 0.15;
            TotalTax += tax;
            Console.WriteLine($"{manager.Name} (Manager) tax: {tax}");
        }

        public void Visit(Contractor contractor)
        {
            double pay = contractor.HourlyRate * contractor.HoursWorked;
            double tax = pay * 0.05;
            TotalTax += tax;
            Console.WriteLine($"{contractor.Name} (Contractor) tax: {tax}");
        }
    }
}
