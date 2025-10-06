namespace DoFactory.GangOfFour.AbstractFactory.MyWorld02.Factories;

using DoFactory.GangOfFour.AbstractFactory.MyWorld02.Products;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

public class WindowsFactory : IGuiFactory
{
    public IButton CreateButton() => new WinButton();
    public ICheckbox CreateCheckbox() => new WinCheckbox();
}
