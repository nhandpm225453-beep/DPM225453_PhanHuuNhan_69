namespace DoFactory.GangOfFour.Builder.MyWorld01;

using DoFactory.GangOfFour.Builder.MyWorld01.Builders;

public class Director
{
    // Builder uses a series of steps
    public void Construct(IComputerBuilder builder)
    {
        builder.BuildCPU();
        builder.BuildGPU();
        builder.BuildRAM();
        builder.BuildStorage();
    }
}
