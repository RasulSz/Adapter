using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Iphone : Phone
    {
        private int workVoltage;
        public Iphone()
        {
            this.workVoltage = 10;
        }
        public int Charge()
        {
            Console.WriteLine("Iphone Successfully Charging");
            return workVoltage;
        }
    }
}
