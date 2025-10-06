using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Myworld23_Vision
{
    public class SizeCalculatorVisitor : IVisitor
    {
        public int TotalSize { get; private set; } = 0;

        public void Visit(File file)
        {
            TotalSize += file.Size;
        }

        public void Visit(Folder folder)
        {
            foreach (var child in folder.Children)
            {
                child.Accept(this);
            }
        }
    }
}
