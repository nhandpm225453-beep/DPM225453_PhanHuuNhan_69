namespace Builder.NetRealWorld;

using System;
using System.Collections.Generic;

/// <summary>
/// The 'Product' class.
/// </summary>
public class Vehicle
{
    private readonly string _vehicleType;
    private readonly Dictionary<string, string> _parts = new();

    // Constructor
    public Vehicle(string vehicleType)
    {
        _vehicleType = vehicleType;
    }

    // Indexer
    public string this[string key]
    {
        get => _parts[key];
        set => _parts[key] = value;
    }

    public void Show()
    {
        Console.WriteLine("\n---------------------------");
        Console.WriteLine($"Vehicle Type: {_vehicleType}");
        Console.WriteLine($" Frame : {_parts["frame"]}");
        Console.WriteLine($" Engine : {_parts["engine"]}");
        Console.WriteLine($" #Wheels: {_parts["wheels"]}");
        Console.WriteLine($" #Doors : {_parts["doors"]}");
    }
}
