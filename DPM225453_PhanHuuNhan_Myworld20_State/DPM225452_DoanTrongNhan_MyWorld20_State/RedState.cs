using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Myworld23_Vision
{
    public class RedState : State
    {
        public override void Handle(Context context)
        {
            context.State = new BlueState();
        }
    }

}
