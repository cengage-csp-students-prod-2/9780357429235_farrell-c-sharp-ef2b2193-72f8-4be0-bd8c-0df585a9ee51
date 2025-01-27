Create an application named *TestClassifiedAd* that instantiates and displays at least two `ClassifiedAd` objects. A `ClassifiedAd` has fields for a `Category` (For example, **Used Cars** and  **Help Wanted**), a number of `Words`, and a price. Include properties that contain `get` and `set` accessors for the category and number of words, but only a `get` accessor for the price. The price is calculated at nine cents per word.


Note: Your output should be formatted as:
`The classified ad with 100 words in category Used Cars costs $9.00`  
`The classified ad with 60 words in category Help Wanted costs $5.40`

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`


