using System;
using static System.Console;
using System.Globalization;
class InchesToCentimeters 
{
	static void Main()
	{
		const double CENTEMETERS_PERS_INCH = 2.54;
		double inches = 3;
		double cm = inches * CENTEMETERS_PERS_INCH;
		WriteLine(inches + " inches is " + cm + " centimeters");
	}
}