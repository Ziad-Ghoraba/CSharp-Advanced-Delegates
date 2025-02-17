using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor
{
    class Sensor
    {
        public event EventHandler<TempArgs> SensorChanged;

        private int CurrentTemperature { get; set; }

        public void ChangeTemperature(int newTemperature)
        {
            CurrentTemperature = newTemperature;
            SensorChanged(this, new TempArgs(newTemperature));
        }
    }
}
