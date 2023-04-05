using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Fridge : PowerTools
    {
        private int volt;
        public Fridge()
        {
            volt = 220;
        }
        public int PowerOn()
        {
            Console.WriteLine("Fridge Successfully Working");
            return volt;
        }
    }
}
