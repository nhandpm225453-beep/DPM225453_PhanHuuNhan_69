using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IElement> elements = new List<IElement>
            {
                new ElementA(),
                new ElementB(),
                new ElementA()
            };
            IVisitor visitor = new ConcreteVisitor();

            foreach (var element in elements)
            {
                element.Accept(visitor);
            }

            Console.ReadKey();
        }
    }
}
