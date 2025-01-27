Write the program `FindSquareRoot` that finds the square root of a user’s input value. The `Math` class contains a static method named `Sqrt()` that accepts a double and returns the parameter’s square root. If the user’s entry cannot be converted to a `double`, display an appropriate message, and set the square root value to 0. Otherwise, test the input number’s value. If it is negative, throw a new `ApplicationException` to which you pass the message “Number can’t be negative.” and again set `sqrt` to 0. If the input value is a `double` and not negative, pass it to the `Math.Sqrt()` method, and display the returned value.

An example of the program is shown below: 
```
Enter a number 9
Square root is 3
```
or 
```
Enter a number -9
Error: Number can't be negative.
Square root is 0
```

