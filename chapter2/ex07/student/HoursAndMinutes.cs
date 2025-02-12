using System;
using static System.Console;
using System.Globalization;
class HoursAndMinutes
{
	static void Main()
	{
		double minutes = 197;
        int hours = (int) minutes / 60;
        double minutesLeft = hours % 60;

        WriteLine("{0} minutes is {1} hours and {2} minutes", minutes, hours, minutesLeft);
	}
}
