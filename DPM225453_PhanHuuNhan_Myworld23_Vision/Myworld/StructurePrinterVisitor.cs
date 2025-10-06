using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Myworld23_Vision
{
    public class StructurePrinterVisitor : IVisitor
    {
        private int _indent = 0;

        private void PrintIndent()
        {
            Console.Write(new string(' ', _indent * 2));
        }

        public void Visit(File file)
        {
            PrintIndent();
            Console.WriteLine($"File: {file.Name} ({file.Size} KB)");
        }

        public void Visit(Folder folder)
        {
            PrintIndent();
            Console.WriteLine($"Folder: {folder.Name}");
            _indent++;
            foreach (var child in folder.Children)
            {
                child.Accept(this);
            }
            _indent--;
        }
    }
}
