using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real
{
    public class Manager : IEmployee
    {
        public string Name { get; }
        public double MonthlySalary { get; }
        public double Bonus { get; }

        public Manager(string name, double monthlySalary, double bonus)
        {
            Name = name;
            MonthlySalary = monthlySalary;
            Bonus = bonus;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
