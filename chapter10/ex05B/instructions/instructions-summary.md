Using the `Automobile` class you created _Chapter 10, Programming Exercise 5A_ as a base, derive a `FinancedAutomobile` class that contains all the data of an Automobile, plus the following field:

- `AmtFinanced` - The amount financed (a `double`)

Override the parent class `ToString()` method to include the child class’s additional data.

Create a program named _AutomobileDemo2_ that contains an array of four `FinancedAutomobile` objects. Prompt the user for all the necessary data, and do not allow duplicate ID numbers and do not allow the amount financed to be greater than the price of the automobile.

Sort all the records in ID number order and display them with a total price for all `FinancedAutomobiles` and a total amount financed. For example, the output should be in the following format:

```
Summary:
FinancedAutomobile 1 2017 Honda Price is $26,000.00 Amount financed $12,000.00
FinancedAutomobile 4 2019 Honda Price is $36,000.00 Amount financed $0.00
FinancedAutomobile 5 2016 Toyota Price is $30,000.00 Amount financed $3,000.00
FinancedAutomobile 8 2018 Honda Price is $16,000.00 Amount financed $6,000.00

Total for all Automobiles is $108,000.00

Total financed all Automobiles is $21,000.00
```

info> In order to prepend the _$_ to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
