namespace DoFactory.GangOfFour.AbstractFactory.MyWorld02.Factories;

using DoFactory.GangOfFour.AbstractFactory.MyWorld02.Products;

public interface IGuiFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}
    