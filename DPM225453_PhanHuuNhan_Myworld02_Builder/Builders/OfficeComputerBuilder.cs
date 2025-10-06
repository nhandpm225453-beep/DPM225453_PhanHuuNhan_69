namespace DoFactory.GangOfFour.Builder.MyWorld01.Builders;

using DoFactory.GangOfFour.Builder.MyWorld01.Products;
using Microsoft.VisualBasic.Devices;

public class OfficeComputerBuilder : IComputerBuilder
{
    private readonly Computer1 computer = new("Office PC");

    public void BuildCPU() => computer["CPU"] = "Intel Core i5";
    public void BuildGPU() => computer["GPU"] = "Integrated Graphics";
    public void BuildRAM() => computer["RAM"] = "16GB DDR4";
    public void BuildStorage() => computer["Storage"] = "512GB SSD";

    public Computer1 GetResult() => computer;
}
    