using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real
{
    public class SalaryCalculatorVisitor : IVisitor
    {
        public double TotalSalary { get; private set; } = 0;

        public void Visit(RegularEmployee employee)
        {
            TotalSalary += employee.MonthlySalary;
            Console.WriteLine($"{employee.Name} (Regular) salary: {employee.MonthlySalary}");
        }

        public void Visit(Manager manager)
        {
            double totalPay = manager.MonthlySalary + manager.Bonus;
            TotalSalary += totalPay;
            Console.WriteLine($"{manager.Name} (Manager) salary + bonus: {totalPay}");
        }

        public void Visit(Contractor contractor)
        {
            double totalPay = contractor.HourlyRate * contractor.HoursWorked;
            TotalSalary += totalPay;
            Console.WriteLine($"{contractor.Name} (Contractor) pay: {totalPay}");
        }
    }
}
