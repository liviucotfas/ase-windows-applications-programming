using System;
using System.Threading;

namespace EventsMethodTrigger
{
    delegate void TemperatureReading(double temperature);

	//Broadcaster
    class TemperatureSensor : IDisposable
    {
		#region Attributes
		private readonly Timer _timer;
	    private readonly Random _random;
		#endregion

		public event TemperatureReading TemperatureReadingChanged;

	    public TemperatureSensor(TimeSpan interval)
	    {
			_random = new Random();
			_timer = new Timer(BroadcastTemperature, null, TimeSpan.FromSeconds(1), interval);
		}

	    private void BroadcastTemperature(object o)
	    {
			if (TemperatureReadingChanged != null)
				TemperatureReadingChanged(_random.NextDouble() * 100);
		}

	    public void Dispose()
	    {
			if(_timer != null)
				_timer.Dispose();
	    }
    }

	//Subscriber or Observer
    class MonitoringService
    {
	    public void TemperatureReadingChanged(double temperature)
	    {
			if(temperature < 25)
				Console.WriteLine("To coooooooold! :(");
			else if (temperature > 30)
				Console.WriteLine("To hooooooooot! :(");
			else
				Console.WriteLine("Just right! :D");	
		}
	}

	class Program
	{
		private static void Main()
        {
			var ts1 = new TemperatureSensor(TimeSpan.FromSeconds(2));
			var ts2 = new TemperatureSensor(TimeSpan.FromSeconds(16));

			ts1.TemperatureReadingChanged += Ts1_TempartureReadingChanged;
			ts2.TemperatureReadingChanged += Ts2_TempartureReadingChanged;

			var monitoringService = new MonitoringService();
			ts1.TemperatureReadingChanged += monitoringService.TemperatureReadingChanged;
			ts2.TemperatureReadingChanged += monitoringService.TemperatureReadingChanged;

			Console.ReadLine();
        }

		private static void Ts1_TempartureReadingChanged(double temperature)
		{
			Console.WriteLine("ProgMain ts1: " + temperature);
		}

		private static void Ts2_TempartureReadingChanged(double temperature)
		{
			Console.WriteLine("ProgMain ts2: " + temperature);
		}
	}
}
