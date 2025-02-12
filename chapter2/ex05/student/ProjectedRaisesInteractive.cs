using System;
using static System.Console;
using System.Globalization;
class ProjectedRaisesInteractive
{
	static void Main()
	{
		const double RAISE = 0.04;
        double employee1 = 0.0f, employee2 = 0.0f, employee3 = 0.0f;
        Write("Enter the salary of employee 1 >> ");
        employee1 = double.Parse(ReadLine());
        Write("Enter the salary of employee 2 >> ");
        employee2 = double.Parse(ReadLine());
        Write("Enter the salary of employee 3 >> ");
        employee3 = double.Parse(ReadLine());

        employee1 += employee1 * RAISE;
        employee2 += employee2 * RAISE;
        employee3 += employee3 * RAISE;

        WriteLine("Next year's salary for the first employee will be {0}",  employee1.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("Next year's salary for the second employee will be {0}", employee2.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("Next year's salary for the third employee will be {0}", employee3.ToString("C", CultureInfo.GetCultureInfo("en-US")));
	}
}
