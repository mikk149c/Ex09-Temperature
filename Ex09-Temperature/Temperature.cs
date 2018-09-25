using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Temperature
{
	public class Temperature
	{
		public double Fahrenheit { get; set; }
		public double Celsius { get; set; }
		public string toString
		{
			get
			{
				if (Fahrenheit != 0)
				{
					return toStringF;
				}
				else if (Celsius != 0)
				{
					return toStringC;
				}
				return "";
			}
		}
		public string toStringF
		{
			get
			{
				return "°F:" + Fahrenheit;
			}
		}
		public string toStringC
		{
			get
			{
				return "°C:" + Celsius;
			}
		}

		public void SetCelsiusFromFahrenheit()
		{
			Celsius = TemperatureUtil.FahrenheitToCelsius(Fahrenheit);
		}

		public void SetFahrenheitFromCelsius()
		{
			Fahrenheit = TemperatureUtil.CelsiusToFahrenheit(Celsius);
		}
	}
}