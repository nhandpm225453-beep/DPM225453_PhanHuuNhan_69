using DPM225453_PhanHuuNhan_Pattern01_AbstractFactory.Products;

namespace DPM225453_PhanHuuNhan_Pattern01_AbstractFactory.Factories
{
    internal abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
