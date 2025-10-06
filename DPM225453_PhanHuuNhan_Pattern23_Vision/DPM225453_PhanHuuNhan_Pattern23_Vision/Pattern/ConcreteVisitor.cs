using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pattern
{
    public class ConcreteVisitor : IVisitor
    {
        public void Visit(ElementA element)
        {
            Console.WriteLine("ConcreteVisitor: Visiting ElementA");
        }

        public void Visit(ElementB element)
        {
            Console.WriteLine("ConcreteVisitor: Visiting ElementB");
        }
    }
}
