using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Myworld21_Strategy
{
    using System;

    namespace Strategy.Structural
    {
        /// <summary>
        /// Strategy Design Pattern - Shipping Strategy Example
        /// </summary>
        public class Program
        {
            public static void Main(string[] args)
            {
                ShippingContext context;

                // Three different shipping strategies

                context = new ShippingContext(new StandardShipping());
                context.CalculateShippingCost();

                context = new ShippingContext(new ExpressShipping());
                context.CalculateShippingCost();

                context = new ShippingContext(new FreeShipping());
                context.CalculateShippingCost();

                // Wait for user to exit
                Console.ReadKey();
            }
        }
        
    }

}
