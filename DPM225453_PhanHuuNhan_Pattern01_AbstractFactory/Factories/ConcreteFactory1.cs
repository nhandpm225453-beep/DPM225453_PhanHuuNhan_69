using DPM225453_PhanHuuNhan_Pattern01_AbstractFactory.Products;

namespace DPM225453_PhanHuuNhan_Pattern01_AbstractFactory.Factories
{
    internal class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
