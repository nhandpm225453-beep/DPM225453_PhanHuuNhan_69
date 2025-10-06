using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DPM225453_PhanHuuNhan_Myworld03_Factory.Vehicle;

namespace DPM225453_PhanHuuNhan_Myworld03_Factory
{

        public class TruckFactory : VehicleFactory
        {
            public override void CreateVehicle()
            {
                Vehicle = new Truck();
                Vehicle.Features.Add("6 wheels");
                Vehicle.Features.Add("Large cargo space");
                Vehicle.Features.Add("Diesel engine");
            }
        }
    }
