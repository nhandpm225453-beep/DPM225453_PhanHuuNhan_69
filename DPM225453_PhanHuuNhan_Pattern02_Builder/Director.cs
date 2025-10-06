namespace Builder.NetStructural;

/// <summary>
/// The 'Director' class.
/// </summary>
public class Director
{
    // Builder uses a complex series of steps
    public void Construct(Builder builder)
    {
        builder.BuildPartA();
        builder.BuildPartB();
    }
}
