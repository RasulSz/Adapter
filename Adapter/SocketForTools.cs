using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SocketForTools
    {
        public void PowerGone(PowerTools powerTools)
        {
            int volt = powerTools.PowerOn();
            Console.WriteLine($"{volt} Volt Power Suplied ");
        }
    }
}
