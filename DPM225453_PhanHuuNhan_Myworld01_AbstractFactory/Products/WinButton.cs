namespace DoFactory.GangOfFour.AbstractFactory.MyWorld02.Products;

using static System.Console;

public class WinButton : IButton
{
    public void Paint() => WriteLine("Render a Windows style button");
}
