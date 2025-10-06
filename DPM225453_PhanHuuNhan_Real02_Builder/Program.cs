namespace Builder.NetRealWorld;

using System;

/// <summary>
/// MainApp startup class for Real-World Builder Design Pattern.
/// </summary>
public class Program
{
    public static void Main()
    {
        VehicleBuilder builder;

        // Create shop with vehicle builders
        var shop = new Shop();

        // Construct and display vehicles
        builder = new ScooterBuilder();
        shop.Construct(builder);
        builder.Vehicle.Show();

        builder = new CarBuilder();
        shop.Construct(builder);
        builder.Vehicle.Show();

        builder = new MotorCycleBuilder();
        shop.Construct(builder);
        builder.Vehicle.Show();

        // Wait for user input
        Console.ReadLine(); // thay ReadKey ?? tránh l?i
    }
}
