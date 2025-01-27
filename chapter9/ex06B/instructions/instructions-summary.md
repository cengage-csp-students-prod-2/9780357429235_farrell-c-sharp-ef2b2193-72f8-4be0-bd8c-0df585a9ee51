Using the _SalesTaxDemo_ program you wrote in _Exercise 6A_, modify that program so that after the 10 `Sale` objects are displayed, they are sorted in order by the amount of tax owed and displayed again. Modify the `Sale` class so its objects are comparable to each other based on tax owed using `IComparable.CompareTo()`. Name this modified program _SalesTaxDemo2_.

Each item should be displayed as follows:

````
Sale # 1 Amount: 567 Sale $1.00
     Tax is $0.08
````

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`

