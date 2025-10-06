using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Myworld21_Strategy
{
    public class ExpressShipping : ShippingStrategy
    {
        public override void CalculateShippingCost()
        {
            Console.WriteLine("Calculating Express Shipping Cost: $15");
        }
    }
}
