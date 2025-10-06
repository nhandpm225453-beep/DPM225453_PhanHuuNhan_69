using System;

namespace DPM225423_NguyenNgocHuy_Pattern01_PrototypeRealWorld
{
    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>
    public class Color : ColorPrototype
    {
        private int red;
        private int green;
        private int blue;

        // Constructor
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        // Create a shallow copy
        public override ColorPrototype Clone()
        {
            Console.WriteLine(
                "Cloning color RGB: {0,3},{1,3},{2,3}",
                red, green, blue);

            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
