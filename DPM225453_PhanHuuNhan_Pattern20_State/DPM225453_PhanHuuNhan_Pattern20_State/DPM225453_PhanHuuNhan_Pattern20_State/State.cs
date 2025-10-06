using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Pattern20_State
{
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}
