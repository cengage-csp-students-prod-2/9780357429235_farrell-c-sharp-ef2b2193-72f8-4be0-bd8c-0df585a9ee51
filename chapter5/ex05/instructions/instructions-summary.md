Danielle, Edward, and Francis are three salespeople at Holiday Homes. Write an
application named *HomeSales* that prompts the user for a salesperson initial (`D`, `E`, or `F`) input as a string. Either uppercase or lowercase initials are valid. While the user does not type **Z**, continue by prompting for the amount of a sale. Issue the error message "**Sorry - invalid salesperson**" for any invalid initials entered. Keep a running total of the amounts sold by each salesperson. After the user types **Z** or *z* for an initial, display each salesperson’s total, a grand total for all sales, and the name of the salesperson with the highest total unless there is a tie. If there is a tie, indicate this in the program's output with the message: "**There was a tie**". 

An example of the program is shown below: 
```
Enter a salesperson initial >> D
Enter amount of sale >> 10
Enter next salesperson intital or Z to quit >> d
Enter amount of sale >> 2
Enter next salesperson intital or Z to quit >> E
Enter amount of sale >> 15
Enter next salesperson intital or Z to quit >> f
Enter amount of sale >> 9
Enter next salesperson intital or Z to quit >> Z
Danielle sold        $12.00
Edward sold          $15.00
Francis sold          $9.00
Total sales were     $36.00
Edward sold the most
```

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
