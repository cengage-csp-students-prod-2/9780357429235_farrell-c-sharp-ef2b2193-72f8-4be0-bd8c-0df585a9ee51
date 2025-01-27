Make any necessary modifications to the `RushJob` `class` so that it can be sorted by job number. Modify the JobDemo3 application so the displayed orders have been sorted. Save the application as JobDemo4.

An example of the program is shown below:

```
Enter job number 22
Enter customer name Joe
Enter description Powerwashing
Enter estimated hours 4
Enter job number 6
Enter customer name Joey
Enter description Painting
Enter estimated hours 8
Enter job number 12
Enter customer name Joseph
Enter description Carpet cleaning
Enter estimated hours 5
Enter job number 9
Enter customer name Josefine
Enter description Moving
Enter estimated hours 12
Enter job number 21
Enter customer name Josefina
Enter description Dog walking
Enter estimated hours 2

Summary:

RushJob 6 Joey Painting 8 hours @$45.00 per hour. Rush job adds 150 premium. Total price is $510.00
RushJob 9 Josefine Moving 12 hours @$45.00 per hour. Rush job adds 150 premium. Total price is $690.00
RushJob 12 Joseph Carpet cleaning 5 hours @$45.00 per hour. Rush job adds 150 premium. Total price is $375.00
RushJob 21 Josefina Dog walking 2 hours @$45.00 per hour. Rush job adds 150 premium. Total price is $240.00
RushJob 22 Joe Powerwashing 4 hours @$45.00 per hour. Rush job adds 150 premium. Total price is $330.00
```

> In order to prepend the _$_ to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
