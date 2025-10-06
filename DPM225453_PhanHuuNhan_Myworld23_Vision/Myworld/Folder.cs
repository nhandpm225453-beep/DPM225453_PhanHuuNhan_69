using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Myworld23_Vision
{
    public class Folder : IFileSystemElement
    {
        public string Name { get; }
        public List<IFileSystemElement> Children { get; } = new List<IFileSystemElement>();

        public Folder(string name)
        {
            Name = name;
        }

        public void Add(IFileSystemElement element)
        {
            Children.Add(element);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
