using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Myworld21_Strategy
{
    public class StandardShipping : ShippingStrategy
    {
        public override void CalculateShippingCost()
        {
            Console.WriteLine("Calculating Standard Shipping Cost: $5");
        }
    }
}
