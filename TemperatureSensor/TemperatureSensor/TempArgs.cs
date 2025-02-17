using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor
{
    class TempArgs : EventArgs
    {
        public int Temperature { get; set; }
        public TempArgs(int temp)
        {
            Temperature = temp;
        }
    }
}
