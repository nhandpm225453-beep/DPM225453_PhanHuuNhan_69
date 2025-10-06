using DPM225453_PhanHuuNhan_Pattern15_Interpreter;

public class Program
{
    public static void Main(string[] args)
    {
        Context context = new Context();
        // Usually a tree 
        List<AbstractExpression> list = new List<AbstractExpression>();
        // Populate 'abstract syntax tree' 
        list.Add(new TerminalExpression());
        list.Add(new NonterminalExpression());
        list.Add(new TerminalExpression());
        list.Add(new TerminalExpression());
        // Interpret
        foreach (AbstractExpression exp in list)
        {
            exp.Interpret(context);
        }
        // Wait for user
        Console.ReadKey();
    }
}