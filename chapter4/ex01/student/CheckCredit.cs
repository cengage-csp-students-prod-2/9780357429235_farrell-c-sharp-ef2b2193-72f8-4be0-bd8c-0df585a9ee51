using System;
using static System.Console;
using System.Globalization;
class CheckCredit
{
	static void Main()
	{
		Write("Please Enter the price purchase >> ");
        double price = double.Parse(ReadLine());
        if (price > 8000){
          Write("You have exceeded the credit limit");
        }
        else{
          Write("Approved");
        }
    
	}
}
