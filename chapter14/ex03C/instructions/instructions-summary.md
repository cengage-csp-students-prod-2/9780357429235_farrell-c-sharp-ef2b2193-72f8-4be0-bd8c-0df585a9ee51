Using the output file generated from your program in _Exercise 3A_, write the program `FindPatientRecords` that prompts the user for an ID number, reads records from **Patients.txt**, and displays data for the specified record. If the record does not exist, display the following error message:

```
No records found for p#
```

An example of the program is shown below:

```
Enter patient ID number to find >> p1

ID Number Name                 Balance

p1        Patient1              $20.00
```

> In order to prepend the _$_ to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
