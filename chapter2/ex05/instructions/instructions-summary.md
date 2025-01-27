Convert the *ProjectedRaises* class to an interactive application named
*ProjectedRaisesInteractive*. Instead of assigning values to the salaries, accept them from the user as input.

Output for each employee should be formatted similar to the following example for the first employee: **Next year's salary for the first employee will be $26,000.00**.

Note: The salary in the output will change depending on the user input.

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`