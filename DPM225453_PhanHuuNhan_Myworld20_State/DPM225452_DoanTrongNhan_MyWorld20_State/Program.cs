namespace DPM225453_PhanHuuNhan_Myworld23_Vision
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var context = new Context(new RedState());

            context.Request();
            context.Request();
            context.Request();

        }
    }
}