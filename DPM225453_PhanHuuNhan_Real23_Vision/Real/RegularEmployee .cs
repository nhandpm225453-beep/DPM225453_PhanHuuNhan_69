using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real
{
    public class RegularEmployee : IEmployee
    {
        public string Name { get; }
        public double MonthlySalary { get; }

        public RegularEmployee(string name, double monthlySalary)
        {
            Name = name;
            MonthlySalary = monthlySalary;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
