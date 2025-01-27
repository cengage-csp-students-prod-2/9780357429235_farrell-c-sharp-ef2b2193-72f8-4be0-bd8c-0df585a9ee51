Write an application named _AutomobileDemo3_ that uses an extension method
for the `FinancedAutomobile` class you wrote in _Chapter 10, Programming Exercise 5B_. The method (`GetPaymentAmount`) computes and returns a FinancedAutomobile’s monthly payment due (1/24 of the amount financed).

The application should allow the user to enter data for four objects and then display all the data for each.

info> In order to prepend the _$_ to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
