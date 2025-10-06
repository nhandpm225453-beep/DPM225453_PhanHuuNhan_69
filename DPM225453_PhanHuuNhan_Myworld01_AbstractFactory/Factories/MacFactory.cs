namespace DoFactory.GangOfFour.AbstractFactory.MyWorld02.Factories;

using DoFactory.GangOfFour.AbstractFactory.MyWorld02.Products;

public class MacFactory : IGuiFactory
{
    public IButton CreateButton() => new MacButton();
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}
