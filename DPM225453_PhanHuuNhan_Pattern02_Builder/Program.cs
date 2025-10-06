namespace Builder.NetStructural;

using System;
using System.IO;

/// <summary>
/// MainApp startup class for Structural Builder Design Pattern.
/// </summary>
public class Program
{
    public static void Main()
    {
        // Create director and builders
        var director = new Director();

        Builder b1 = new ConcreteBuilder1();
        Builder b2 = new ConcreteBuilder2();

        // Construct two products
        director.Construct(b1);
        var p1 = b1.GetResult();
        p1.Show();

        director.Construct(b2);
        var p2 = b2.GetResult();
        p2.Show();

        // Wait for user input
        Console.ReadLine(); // thay cho ReadKey() để tránh lỗi
    }
}
