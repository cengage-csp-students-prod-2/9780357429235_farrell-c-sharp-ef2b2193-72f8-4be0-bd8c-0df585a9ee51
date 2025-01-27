Write a program named _DemoJobs_ for Harold’s Home Services. The program
should instantiate several `Job` objects and demonstrate their methods. The `Job` class contains four data fields

- `Description` (for example, “wash windows”),
- `Time` in hours to complete (for example, 3.5),
- `Hourly` per-hour rate charged (for example, $25.00),
- `Total` fee (hourly rate times hours).

Include properties to get and set each field except the `total`-- that field will be read-only, and its value is calculated each time either the hourly fee or the number of hours is set. Round to two decimal places.

Overload the + operator so that two `Jobs` can be added. The sum of two `Jobs` is a new `Job` containing the descriptions of both original Jobs (joined by `and`), the sum of the time in hours for the original `Jobs`, and the average of the hourly rate for the original `Jobs`.

> In order to prepend the _$_ to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
