using System;

namespace DPM225453_PhanHuuNhan_Myworld01_Bridge
{
    /// <summary>
    /// Bridge Pattern - MyWorld01 Example (Shapes & Colors)
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            RefinedShape circle = new RefinedShape("Circle");
            circle.Color = new RedColor();
            circle.Draw();

            RefinedShape rectangle = new RefinedShape("Rectangle");
            rectangle.Color = new BlueColor();
            rectangle.Draw();

            RefinedShape triangle = new RefinedShape("Triangle");
            triangle.Color = new RedColor();
            triangle.Draw();

            Console.ReadKey();
        }
    }
}
