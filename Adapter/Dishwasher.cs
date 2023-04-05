using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Dishwasher : PowerTools
    {
        private int volt;
        public Dishwasher()
        {
            volt = 220;
        }
        public int PowerOn()
        {
            Console.WriteLine("Dishwasher Successfully Working.");
            return volt;
        }
    }
}
