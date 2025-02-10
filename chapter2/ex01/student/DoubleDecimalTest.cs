using System;
using static System.Console;
using System.Globalization;
class InchesToCentimeters 
{
	static void Main()
	{
		const double CENTEMETERS_PERS_INCH = 2.54;
		float inches = 3;
		float cm = inches * CENTEMETERS_PERS_INCH;
		WriteLine(inches + " inches is " + cm + " centimeters");
	}
}