namespace DoFactory.GangOfFour.AbstractFactory.MyWorld02;

using DoFactory.GangOfFour.AbstractFactory.MyWorld02.Factories;
using static System.Console;

public class Program
{
    public static void Main()
    {
        IGuiFactory factory;

        WriteLine("Nhap OS (win/mac): ");
        var os = ReadLine()?.ToLower();

        factory = os == "mac" ? new MacFactory() : new WindowsFactory();

        var app = new Application(factory);
        app.CreateUI();
        app.Paint();

        ReadKey();
    }
}
