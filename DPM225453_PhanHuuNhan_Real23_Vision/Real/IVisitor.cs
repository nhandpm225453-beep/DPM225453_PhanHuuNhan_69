using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real
{
    public interface IVisitor
    {
        void Visit(RegularEmployee employee);
        void Visit(Manager manager);
        void Visit(Contractor contractor);
    }
}
