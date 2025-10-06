using DPM225453_PhanHuuNhan_Real22_Template;

public class Program
{
    public static void Main(string[] args)
    {
        DataAccessor categories = new Categories();
        categories.Run(5);
        DataAccessor products = new Products();
        products.Run(3);
        // Wait for user
        Console.ReadKey();
    }
}