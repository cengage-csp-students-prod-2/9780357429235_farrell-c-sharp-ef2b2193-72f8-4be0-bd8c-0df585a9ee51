using System;
using static System.Console;
using System.Globalization;
class ProjectedRaises
{
	static void Main()
	{
		const double RAISE = 0.04;
        double employee1 = 25000, employee2 = 38000, employee3 = 51000;
        WriteLine("The salary of employee 1 is {0}", employee1.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("The salary of employee 2 is {0}", employee2.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("The salary of employee 3 is {0}", employee3.ToString("C", CultureInfo.GetCultureInfo("en-US")));

        employee1 += employee1 * RAISE;
        employee2 += employee2 * RAISE;
        employee3 += employee3 * RAISE;

        WriteLine("Next year's salary for the first employee will be {0}",  employee1.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("Next year's salary for the second employee will be {0}", employee2.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("Next year's salary for the third employee will be {0}", employee3.ToString("C", CultureInfo.GetCultureInfo("en-US")));
	}
}
