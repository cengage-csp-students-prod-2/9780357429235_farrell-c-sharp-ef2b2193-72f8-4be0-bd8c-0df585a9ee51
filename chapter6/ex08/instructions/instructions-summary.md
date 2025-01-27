Write a program for The Carefree Resort named *ResortPrices* that prompts the user to enter the number of days for a resort stay. Then display the price per night and the total price. 
Nightly rates are:
* $200 for one or two nights
* $180 for three or four nights
* $160 for five, six, or seven nights
* $145 for eight nights or more

For example, if the input is **1**, the output should be:
```
Price per night is $200.00
Total for 1 night(s) is $200.00
```

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`

