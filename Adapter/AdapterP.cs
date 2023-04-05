using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdapterP : PowerTools
    {
        private Phone phone;
        public AdapterP(Phone phone)
        {
            this.phone = phone;
        }

        public int PowerOn()
        {
            return phone.Charge();
        }
    }
}
