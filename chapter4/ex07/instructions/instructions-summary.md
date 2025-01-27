Account numbers sometimes contain a check digit that is the result of a mathematical calculation. The inclusion of the digit in an account number helps ascertain whether the number is a valid one.

Write an application named *CheckDigit* that asks a user to enter a four-digit account number and determines whether it is a valid number.

The number is valid if the fourth digit is the remainder when the number represented by the first three digits of the four-digit number is divided by 7.  For example, 7770 is valid, because 0 is the remainder when 777 is divided by 7.

If the account number is valid, output **The account number is valid**.  If the account number is invalid output **Invalid**. If the account number is too short or too long output **Account number invalid - it must have 4 digits**. 

