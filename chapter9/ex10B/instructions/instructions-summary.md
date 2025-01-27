### Summary

Harold has realized that his method for computing the fee for combined jobs is not fair. For example, consider the following:

- His fee for painting a house is $100 per hour. If a job takes 10 hours, he earns
  $1000.
- His fee for dog walking is $10 per hour. If a job takes 1 hour, he earns $10.
- If he combines the two jobs and works a total of 11 hours, he earns only the
  average rate of $55 per hour, or $605.

### Instructions

Devise an improved, weighted method for calculating Harold’s fees for combined
Jobs and include it in the overloaded `operator+()` method. To calculate the weighted rate, add the total fee for the first job and the total fee for the second job, divided by the total time to complete both jobs.

For example, using the information in the _Summary_ section:

```
$1000 + $10 / 11 hours = weighted rate of $91.81 per hour
```

Write a program named _DemoJobs2_ that demonstrates all the methods in the class work correctly.

info> In order to prepend the _$_ to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
