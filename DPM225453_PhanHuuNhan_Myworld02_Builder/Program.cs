namespace DoFactory.GangOfFour.Builder.MyWorld01;

using DoFactory.GangOfFour.Builder.MyWorld01.Builders;
using static System.Console;

public class Program
{
    public static void Main()
    {
        var director = new Director();

        // Build a Gaming Computer
        IComputerBuilder gamingBuilder = new GamingComputerBuilder();
        director.Construct(gamingBuilder);
        var gamingPC = gamingBuilder.GetResult();
        gamingPC.Show();

        // Build an Office Computer
        IComputerBuilder officeBuilder = new OfficeComputerBuilder();
        director.Construct(officeBuilder);
        var officePC = officeBuilder.GetResult();
        officePC.Show();
        //Console.ReadLine();
        Console.ReadKey();
    }
}
