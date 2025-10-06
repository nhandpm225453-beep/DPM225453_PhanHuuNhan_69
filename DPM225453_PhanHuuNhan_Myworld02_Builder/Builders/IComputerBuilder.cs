namespace DoFactory.GangOfFour.Builder.MyWorld01.Builders;

using DoFactory.GangOfFour.Builder.MyWorld01.Products;
using Microsoft.VisualBasic.Devices;

public interface IComputerBuilder
{
    void BuildCPU();
    void BuildGPU();
    void BuildRAM();
    void BuildStorage();

   Computer1 GetResult();
}
