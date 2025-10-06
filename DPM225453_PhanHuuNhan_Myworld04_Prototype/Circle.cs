using System;

namespace DPM225453_PhanHuuNhan_Myworld01_PrototypeRealWorld
{
    /// <summary>
    /// The 'ConcretePrototype' class - Circle
    /// </summary>
    public class Circle : ShapePrototype
    {
        public int Radius { get; private set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override ShapePrototype Clone()
        {
            Console.WriteLine("Cloning Circle with radius {0}", Radius);
            return this.MemberwiseClone() as ShapePrototype;
        }
    }
}
