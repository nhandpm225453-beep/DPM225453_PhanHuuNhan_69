namespace DoFactory.GangOfFour.AbstractFactory.MyWorld02;

using DoFactory.GangOfFour.AbstractFactory.MyWorld02.Factories;
using DoFactory.GangOfFour.AbstractFactory.MyWorld02.Products;

public class Application(IGuiFactory factory)
{
    private IButton? button;
    private ICheckbox? checkbox;

    public void CreateUI()
    {
        button = factory.CreateButton();
        checkbox = factory.CreateCheckbox();
    }

    public void Paint()
    {
        button?.Paint();
        checkbox?.Paint();
    }
}
