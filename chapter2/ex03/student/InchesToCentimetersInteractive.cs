using System;
using static System.Console;
using System.Globalization;
class InchesToCentimeterslnteractive
{
	static void Main()
	{
		const double CENTIMETERS_PER_INCHES = 2.54;
		Write("Enter a length in inches >> ");
		double inches =  double.Parse(ReadLine());
		double centimeter = inches * CENTIMETERS_PER_INCHES;
		
		WriteLine(inches + " inches is " + centimeter + " centimeters");
	
	}
}
