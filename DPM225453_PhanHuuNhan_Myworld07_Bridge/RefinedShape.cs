using System;

namespace DPM225453_PhanHuuNhan_Myworld01_Bridge
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class RefinedShape : ShapeBase
    {
        public RefinedShape(string shapeName) : base(shapeName)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("--------------------");
            base.Draw();
            Console.WriteLine("--------------------");
        }
    }
}
