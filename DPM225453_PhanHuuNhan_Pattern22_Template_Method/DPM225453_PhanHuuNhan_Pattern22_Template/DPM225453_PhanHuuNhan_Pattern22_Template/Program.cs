using DPM225453_PhanHuuNhan_Pattern22_Template;

public class Program
{
    public static void Main(string[] args)
    {
        AbstractClass aA = new ConcreteClassA();
        aA.TemplateMethod();
        AbstractClass aB = new ConcreteClassB();
        aB.TemplateMethod();
        // Wait for user
        Console.ReadKey();
    }
}