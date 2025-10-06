using System;

namespace DPM225453_PhanHuuNhan_Myworld01_Bridge
{
    /// <summary>
    /// ConcreteImplementor - Red Color
    /// </summary>
    public class RedColor : ColorImplementor
    {
        public override void Paint(string shapeName)
        {
            Console.WriteLine($"Painting {shapeName} in Red color.");
        }
    }
}
