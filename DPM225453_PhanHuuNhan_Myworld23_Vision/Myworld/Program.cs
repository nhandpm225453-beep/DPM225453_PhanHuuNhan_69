using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Myworld23_Vision
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var root = new Folder("Root");
            var documents = new Folder("Documents");
            var images = new Folder("Images");

            documents.Add(new File("resume.docx", 120));
            documents.Add(new File("project.pdf", 2000));

            images.Add(new File("photo1.jpg", 3500));
            images.Add(new File("photo2.png", 2800));

            root.Add(documents);
            root.Add(images);
            root.Add(new File("notes.txt", 15));

            var sizeVisitor = new SizeCalculatorVisitor();
            root.Accept(sizeVisitor);
            Console.WriteLine($"Total size: {sizeVisitor.TotalSize} KB\n");

            var printerVisitor = new StructurePrinterVisitor();
            root.Accept(printerVisitor);

            Console.ReadKey();
        }
    }
}
