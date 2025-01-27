Create an application named `JobDemo` that declares and uses `Job` objects. The `Job` `class` holds job information for a home repair service. The class has five properties that include:

- `JobNumber` - The job number - `int`
- `Customer` - The customer name - `string`
- `Description` - The job description - `string`
- `Hours` - The estimated hours - `double`
- `price` - The price for the job

Create a constructor that requires parameters for all the data except `price`. Follow the order and data type above. Include auto-implemented properties for the `job number`, `customer name`, and `job description`, but not for `hours` or `price`; the `price` field value is calculated as estimated hours times $45.00 ($45.00 / hour) whenever the `hours` value is set.

Also create the following methods for the`Job` class:

- An `Equals()` method that determines two Jobs are equal if they have the same job number
- A `GetHashCode()` method that returns the job number
- A `ToString()` method that returns a string containing all job information in the following format:

```
Job 111 Smith exterior paint 20 hours @$45.00 per hour. Total price is $900.00
```

The `JobDemo` application declares a few `Job` objects, sets their values, and demonstrates that all the methods work as expected.

info> In order to prepend the _$_ to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
