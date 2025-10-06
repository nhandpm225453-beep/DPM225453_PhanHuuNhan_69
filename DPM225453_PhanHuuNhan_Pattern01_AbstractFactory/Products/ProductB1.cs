using System;

namespace DPM225453_PhanHuuNhan_Pattern01_AbstractFactory.Products
{
    internal class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine($"{this.GetType().Name} interacts with {a.GetType().Name}");
        }
    }
}
