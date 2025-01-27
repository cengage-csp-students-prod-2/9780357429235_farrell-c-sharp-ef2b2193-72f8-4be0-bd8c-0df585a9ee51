Malcolm Movers charges a base rate of $200 per move plus $150 per hour and $2 per mile. 

Write a program named *MoveEstimator* that prompts a user for and accepts estimates for the number of hours for a job and the number of miles involved in the move and displays the total moving fee.

For example, if **25** hours and **55** miles are input the output would be displayed as: **For a move taking 25 hours and going 55 miles the estimate is $4,060.00**

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
