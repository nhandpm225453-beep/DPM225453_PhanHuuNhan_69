using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Myworld21_Strategy
{
    public class FreeShipping : ShippingStrategy
    {
        public override void CalculateShippingCost()
        {
            Console.WriteLine("Calculating Free Shipping Cost: $0");
        }
    }
}
