using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor
{
    class Display
    {
        public void ShowTemperature(object obj, TempArgs args)
        {
            Console.WriteLine($"The temperature now set to {args.Temperature} from display.");
        }
    }
}
