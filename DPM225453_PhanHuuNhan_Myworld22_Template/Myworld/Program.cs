using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Myworld22_Template
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Beverage tea = new Tea();
            Console.WriteLine("Making tea...");
            tea.PrepareRecipe();

            Console.WriteLine();

            Beverage coffee = new Coffee();
            Console.WriteLine("Making coffee...");
            coffee.PrepareRecipe();

            Console.ReadKey();
        }
    }
}
