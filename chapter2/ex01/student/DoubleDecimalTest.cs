using System;
using static System.Console;
using System.Globalization;
class InchesToCentimeters 
{
	static void Main()
	{
		const float inchtocm = 2.54;
		float inches = 3;
		float cm = inches * inchtocm;
		WriteLine(inches);
		Write(" inches is ")
		WriteLine(cm);
		Write(" centimeters");
	}
}