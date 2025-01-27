Write the program `BookExceptionDemo` for the Peterman Publishing Company. Create a `BookException` class that is instantiated when a `Book`’s price exceeds 10 cents per page and whose constructor requires three arguments for title, price, and number of pages. Create an error message that is passed to the `Exception` class constructor for the `Message` property when a `Book` does not meet the price-to-pages ratio. For example, an error message:
```
For Goodnight Moon, ratio is invalid. 
...Price is $12.99 for 25 pages.
```

Next, create a `Book` class that contains fields for title (`string`), author (`string`), price (`double`), and number of pages (`int`) use this specific order for your constructor. Include properties for each field. Throw a `BookException` if a client program tries to construct a `Book` object for which the price is more than 10 cents per page.

Finally, using the `Book` class, create an array of five `Book`s. Prompt the user for values for each `Book`. To handle any exceptions that are thrown because of improper or invalid data entered by the user, set the `Book`’s price to the maximum of 10 cents per page. At the end of the program, display all the entered, and possibly corrected, records.

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`


