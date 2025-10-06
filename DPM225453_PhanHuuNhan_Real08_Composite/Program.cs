using System;

namespace DPM225423_NguyenNgocHuy_Real01_Composite
{
    /// <summary>
    /// Composite Design Pattern - Real World Example
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a tree structure 
            CompositeElement root = new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            // Create a branch
            CompositeElement comp = new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            // Add and remove a PrimitiveElement
            PrimitiveElement pe = new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes
            root.Display(1);

            // Wait for user
            Console.ReadKey();
        }
    }
}
