using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor
{
    class Sensor
    {
        private Broker _broker;

        public Sensor(Broker broker)
        {
            _broker = broker;
        }

        private int CurrentTemperature { get; set; }

        public void ChangeTemperature(int newTemperature)
        {
            CurrentTemperature = newTemperature;
            _broker.Publish("TemperatureChanged", new TempArgs(newTemperature));
        }
    }
}
