using System;

namespace DPM225453_PhanHuuNhan_Myworld03_Factory
{
    class Program
    {
        static void Main()
        {
            VehicleFactory[] factories = new VehicleFactory[]
            {
                new CarFactory(),
                new BikeFactory(),
                new TruckFactory()
            };

            foreach (var factory in factories)
            {
                factory.Vehicle.ShowFeatures();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}