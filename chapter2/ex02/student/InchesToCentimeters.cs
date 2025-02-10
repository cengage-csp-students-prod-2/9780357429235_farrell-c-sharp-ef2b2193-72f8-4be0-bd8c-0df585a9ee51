using System;
using static System.Console;
using System.Globalization;
class InchesToCentimeters
{
	static void Main()
	{
		const double CENTIMETERS_PER_INCHES = 2.54;
		double inches = 3;
		double centimeter = inches * CENTIMETERS_PER_INCHES;
		WriteLine(inches + " inches is " + centimeter + " centimeters");
	}
}