using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor
{
    class Alarm
    {
        private int Threshold { get; set; }

        public Alarm(int thresholdTemp)
        {
            Threshold = thresholdTemp;
        }

        public void SetThreshold(int newThreshold)
        {
            Threshold = newThreshold;
        }

        public void FireAlarm(object obj, TempArgs args)
        {
            if(Threshold < args.Temperature)
            {
                Console.WriteLine($"Take care, The temperature {args.Temperature} is greater than {Threshold}");
                Console.Beep(1000, 300);
            }
        }
    }
}
