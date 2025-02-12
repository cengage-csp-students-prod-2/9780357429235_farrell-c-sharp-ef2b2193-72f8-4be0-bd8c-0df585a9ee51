using System;
using static System.Console;
using System.Globalization;
class FahrenheitToCelsius
{
	static void Main()
	{
		Write("Enter the temperature in Fahrenheit >> ");
        double fahrenheit = double.Parse(ReadLine());

        double celsius = (fahrenheit - 32) * (double)(5.0 / 9.0);

        WriteLine("{0} F is {1} C", fahrenheit.ToString("0.0"), celsius.ToString("0.0"));
	}
}
