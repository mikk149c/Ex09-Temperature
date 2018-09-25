using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Temperature
{
	public class TemperatureUtil
	{
		public static double FahrenheitToCelsius(double v)
		{
			return (v - 32) * (5.0 / 9.0);
		}

		public static double CelsiusToFahrenheit(double v)
		{
			return v / (5.0 / 9.0) + 32;
		}

		public static Temperature[] saveStringArrayCelsius(string[] tempraturs)
		{
			Temperature[] array = new Temperature[tempraturs.Length];	//New array to hold temperaturs set to he length of the string array holding the tempreatures
			for (int i = 0; i < tempraturs.Length; i++)					//For each position in string array
			{
				array[i] = new Temperature();							//Make a new instatns of the teperatur type in the teperatur array
				array[i].Celsius = Convert.ToDouble(tempraturs[i]);		//Convert the string at the current postion to a fouble and save it to the new teperatur at the current position
			}
			return array;
		}

		public static Temperature[] saveStringArrayFahrenheit(string[] tempraturs)
		{
			Temperature[] array = new Temperature[tempraturs.Length];
			for (int i = 0; i < tempraturs.Length; i++)
			{
				array[i] = new Temperature();
				array[i].Fahrenheit = Convert.ToDouble(tempraturs[i]);
			}
			return array;
		}

		public static string printTemperatureArray(Temperature[] temperatures)
		{
			string str = "";
			for (int i = 0; i < temperatures.Length; i++)
			{
				str += " " + temperatures[i].toString;
			}
			return str.Trim();
		}
	}
}
