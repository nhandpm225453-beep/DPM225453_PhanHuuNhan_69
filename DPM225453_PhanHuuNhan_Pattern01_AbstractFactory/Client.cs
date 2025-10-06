using DPM225453_PhanHuuNhan_Pattern01_AbstractFactory.Factories;
using DPM225453_PhanHuuNhan_Pattern01_AbstractFactory.Products;

namespace DPM225453_PhanHuuNhan_Pattern01_AbstractFactory
{
    internal class Client
    {
        private readonly AbstractProductA _abstractProductA;
        private readonly AbstractProductB _abstractProductB;

        public Client(AbstractFactory factory)
        {
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
