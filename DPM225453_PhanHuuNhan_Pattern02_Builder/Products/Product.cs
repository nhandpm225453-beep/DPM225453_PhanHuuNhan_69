namespace Builder.NetStructural;

using System;
using System.Collections.Generic;

/// <summary>
/// The 'Product' class.
/// </summary>
public class Product
{
    private readonly List<string> _parts = new();

    public void Add(string part) => _parts.Add(part);

    public void Show()
    {
        Console.WriteLine("\nProduct Parts -------");
        foreach (string part in _parts)
        {
            Console.WriteLine(part);
        }
    }
}
