Using the `Job` class you created in _Exercise 3a_, write a new application named JobDemo2 that creates an `array` of five `Job` objects. Prompt the user for values for each `Job`. Do not allow duplicate job numbers; force the user to reenter the job when a duplicate job number is entered. When five valid objects have been entered, display them all, plus a total of all prices.

An example of the program is shown below:

```C#
Enter job number 1
Enter customer name Bobbi
Enter job description Carpet Cleaning
Enter estimated hours for job 4
Enter job number 2
Enter customer name Sarah
Enter job description Flooding
Enter estimated hours for job 12
Enter job number 3
Enter customer name Taylor
Enter job description Flooring
Enter estimated hours for job 12
Enter job number 4
Enter customer name Sam
Enter job description Gardening
Enter estimated hours for job 6
Enter job number 5
Enter customer name Alex
Enter job description Renovations
Enter estimated hours for job 60

Summary:

Job 1 Bobbi Carpet Cleaning 4 hours @$45.00 per hour. Total price is $180.00
Job 2 Sarah Flooding 12 hours @$45.00 per hour. Total price is $540.00
Job 3 Taylor Flooring 12 hours @$45.00 per hour. Total price is $540.00
Job 4 Sam Gardening 6 hours @$45.00 per hour. Total price is $270.00
Job 5 Alex Renovations 60 hours @$45.00 per hour. Total price is $2,700.00

Total for all jobs is $4,230.00
```

> In order to prepend the _$_ to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
