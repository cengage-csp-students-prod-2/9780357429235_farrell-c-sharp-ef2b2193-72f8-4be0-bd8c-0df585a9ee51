using System;
using static System.Console;
using System.Globalization;
class MoveEstimator
{
	static void Main()
	{
		const double baseRate = 200.0;
        double Rate_Per_hour = 150.0;
        double Rate_Per_Mile = 2.0;

        Write("Enter the number of hours >> ");
        double hour = double.Parse(ReadLine());
        Write("Enter the number of miles >> ");
        double mile = double.Parse(ReadLine());

        double estimate = baseRate + (Rate_Per_hour * hour) + (Rate_Per_Mile * mile);

        WriteLine("*For a move taking {0} hours and going {1} miles the estimate is {2}", hour, mile, estimate.ToString("C", CultureInfo.GetCultureInfo("en-US")));

    }
}
