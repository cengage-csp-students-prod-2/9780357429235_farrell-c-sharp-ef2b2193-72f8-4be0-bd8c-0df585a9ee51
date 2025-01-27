Create a program named _Auction_ that allows a user to enter an amount bid on an online auction item. Include three overloaded methods that accept an `int`, `double`, or `string` bid. Each method should display the bid and indicate whether it is over the minimum acceptable bid of $10.

If the bid is greater than or equal to $10, display **Bid accepted**.

If the bid is less than $10, display **Bid not high enough**.

If the bid is a string, accept it only if one of the following is true:

- It is numeric and preceded with a dollar sign.
- It is numeric and followed by the word dollars.

Otherwise, display a message that says **Bid was not in correct format**.

Examples of the program are shown below:

```
Please enter your bid >> 12
Bid accepted
```

```
Please enter your bid >> 4
Bid not high enough
```
