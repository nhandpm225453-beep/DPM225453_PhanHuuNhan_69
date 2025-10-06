namespace DoFactory.GangOfFour.AbstractFactory.MyWorld02.Products;

using static System.Console;

public class WinCheckbox : ICheckbox
{
    public void Paint() => WriteLine("Render a Windows style checkbox");
}
