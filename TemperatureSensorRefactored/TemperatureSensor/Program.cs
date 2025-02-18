namespace TemperatureSensor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sensor => Adjust temp (input temp)
            //Display 
            //Alarm

            Broker broker = new();
            Sensor sensor = new(broker); //Publisher
            Display display = new(); //Subscribers
            Alarm alarm = new Alarm(50); //Subscribers

            //Subscription
            display.Subscriber(broker);
            alarm.Subscribe(broker);

            while (true) { 
                Console.WriteLine("Welcome to the temperature system");
                Console.WriteLine("1. Set the Alarm Threshold (default 20)");
                Console.WriteLine("2. Set the Temperature");
                Console.WriteLine("3. Exit");

                int result = Convert.ToInt32(Console.ReadLine());

                switch(result)
                {
                    case 1:
                        Console.Write("Please enter the alarm threshold value in degrees: ");
                        int alarmThreshold = Convert.ToInt32(Console.ReadLine());
                        alarm.SetThreshold(alarmThreshold);
                        break;
                    case 2:
                        Console.Write("Please enter the temperature value in degrees: ");
                        int temp = Convert.ToInt32(Console.ReadLine());
                        sensor.ChangeTemperature(temp);
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Wrong input, Please enter correct value");
                        break;
                }

            }

        }
    }
}
