using System;

namespace DPM225453_PhanHuuNhan_Myworld01_Bridge
{
    /// <summary>
    /// ConcreteImplementor - Blue Color
    /// </summary>
    public class BlueColor : ColorImplementor
    {
        public override void Paint(string shapeName)
        {
            Console.WriteLine($"Painting {shapeName} in Blue color.");
        }
    }
}
