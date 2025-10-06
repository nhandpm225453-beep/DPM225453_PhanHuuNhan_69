using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Myworld23_Vision
{
    public class File : IFileSystemElement
    {
        public string Name { get; }
        public int Size { get; } 

        public File(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
