namespace DoFactory.GangOfFour.Builder.MyWorld01.Builders;

using DoFactory.GangOfFour.Builder.MyWorld01.Products;
using Microsoft.VisualBasic.Devices;

public class GamingComputerBuilder : IComputerBuilder
{
    private readonly Computer1 computer = new("Gaming PC");

    public void BuildCPU() => computer["CPU"] = "Intel Core i9";
    public void BuildGPU() => computer["GPU"] = "NVIDIA RTX 4090";
    public void BuildRAM() => computer["RAM"] = "32GB DDR5";
    public void BuildStorage() => computer["Storage"] = "1TB NVMe SSD";

    public Computer1 GetResult() => computer;
}
