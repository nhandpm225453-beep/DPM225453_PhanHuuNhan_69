using System;

namespace DPM225453_PhanHuuNhan_Myworld01_PrototypeRealWorld
{
    /// <summary>
    /// Prototype Design Pattern - MyWorld01 Example (Shapes)
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            ShapeManager manager = new ShapeManager();

            // Initialize with standard shapes
            manager["circle"] = new Circle(10);
            manager["rectangle"] = new Rectangle(20, 10);

            // User adds custom shapes
            manager["bigcircle"] = new Circle(50);
            manager["smallrect"] = new Rectangle(5, 3);

            // User clones selected shapes
            Circle c1 = manager["circle"].Clone() as Circle;
            Rectangle r1 = manager["rectangle"].Clone() as Rectangle;
            Circle c2 = manager["bigcircle"].Clone() as Circle;

            Console.WriteLine("Cloned: Circle with radius {0}", c1.Radius);
            Console.WriteLine("Cloned: Rectangle {0}x{1}", r1.Width, r1.Height);
            Console.WriteLine("Cloned: Big circle with radius {0}", c2.Radius);

            // Wait for user
            Console.ReadKey();
        }
    }
}
