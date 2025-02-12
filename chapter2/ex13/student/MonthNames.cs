using System;
using static System.Console;
using System.Globalization;
class MonthNames
{
    enum Months
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
	static void Main()
	{

        Write("Enter a month number >> ");
        int monthNumber = int.Parse(ReadLine());

        WriteLine("The month is {0}", (Months)monthNumber);

	}
}
