namespace DoFactory.GangOfFour.AbstractFactory.MyWorld02.Products;

using static System.Console;

public class MacCheckbox : ICheckbox
{
    public void Paint() => WriteLine("Render a MacOS style checkbox");
}
