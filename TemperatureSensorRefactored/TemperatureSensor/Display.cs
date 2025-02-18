using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor
{
    class Display
    {

        public void Subscriber(Broker broker)
        {
            broker.Subscribe("TemperatureChanged", ShowTemperature);
        }
        public void ShowTemperature(TempArgs args)
        {
            Console.WriteLine($"The temperature now set to {args.Temperature} from display.");
        }
    }
}
