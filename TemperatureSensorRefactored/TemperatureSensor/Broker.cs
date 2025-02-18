using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor
{
    class Broker
    {
        // Create a dictionary to hold Subjects and Subscribers
        private Dictionary<string, List<Action<TempArgs>>> _SubscriperList = new();

        /*
         * TempChanged , (Alarm, Display)
         */

        public void Subscribe(string subject, Action<TempArgs> action)
        {
            // Adding the action (handler) to the subscription list
            if(!_SubscriperList.ContainsKey(subject))
                _SubscriperList.Add(subject, new List<Action<TempArgs>>() );

            _SubscriperList[subject].Add(action); 
        }

        public void Publish(string subject , TempArgs tempArgs)
        {
            if(_SubscriperList.ContainsKey(subject))
                foreach(Action<TempArgs> method in _SubscriperList[subject])
                    method(tempArgs);

        }


    }
}
