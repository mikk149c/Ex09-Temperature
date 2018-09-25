using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Temperature
{
	class Program
	{
		static void Main(string[] args)
		{
			System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\mikke\Dropbox\Docs\School\EAL\#Programmering\C#\Ex09-Temperature\Ex09-Temperature\InputFil.txt");
			string line = file.ReadToEnd();
			if (line != null)
			{
				string[] lines = line.Split('\n');
				string[] celsiusStrings = lines[0].Split(' ');
				string[] fahrenheitStrings = lines[1].Split(' ');

				Temperature[] temperatures;
				temperatures = TemperatureUtil.saveStringArrayCelsius(celsiusStrings);
				Console.WriteLine(TemperatureUtil.printTemperatureArray(temperatures));

				temperatures = TemperatureUtil.saveStringArrayFahrenheit(fahrenheitStrings);
				Console.WriteLine(TemperatureUtil.printTemperatureArray(temperatures));
			}
		}
	}
}