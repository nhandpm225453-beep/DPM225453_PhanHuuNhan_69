namespace DoFactory.GangOfFour.Builder.MyWorld01.Products;

using static System.Console;

public class Computer1(string type)
{
    private readonly Dictionary<string, string> parts = new();
    private readonly string type = type;

    public string this[string key]
    {
        get => parts[key];
        set => parts[key] = value;
    }

    public void Show()
    {
        WriteLine($"\n---- {type} ----");
        foreach (var part in parts)
        {
            WriteLine($"{part.Key}: {part.Value}");
        }
    }
}
