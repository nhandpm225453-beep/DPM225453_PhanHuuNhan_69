namespace DoFactory.GangOfFour.AbstractFactory.MyWorld02.Products;

using static System.Console;

public class MacButton : IButton
{
    public void Paint() => WriteLine("Render a MacOS style button");
}
