Write the application *AutomobileDemo* that prompts a user for data for eight `Automobile` objects. 

The `Automobile` `class` includes the following auto-implemented properties:
* `IdNumber` - The ID number (an `int`)
* `Make` - The make (a `string`)
* `Year` - The year (an `int`)
* `Price` - The price (a `double`)

Include a default, empty constructor and a constructor that accept all of the above properties.

Override the `ToString()` method to return all the details for an Automobile. 

During data entry, re-prompt the user if any ID number is a duplicate. Sort the objects in ID number order, and display all their data as well as a total of all their prices.  For example if, the output should be in the following format (only two automobiles shown):
```
Automobile 1 2017 honda Price is $30,000.00
Automobile 45 2016 Toyota Price is $20,000.00

Total for all Automobiles is $50,000.00
```

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`


