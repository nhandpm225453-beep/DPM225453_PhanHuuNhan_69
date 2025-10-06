using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real
{
    public class Contractor : IEmployee
    {
        public string Name { get; }
        public double HourlyRate { get; }
        public int HoursWorked { get; }

        public Contractor(string name, double hourlyRate, int hoursWorked)
        {
            Name = name;
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
