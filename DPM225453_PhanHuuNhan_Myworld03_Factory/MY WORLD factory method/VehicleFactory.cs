using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Myworld03_Factory
{

        public abstract class VehicleFactory
        {
            public Vehicle Vehicle;

            public VehicleFactory()
            {
                CreateVehicle();
            }

            public abstract void CreateVehicle();
        }
    }

