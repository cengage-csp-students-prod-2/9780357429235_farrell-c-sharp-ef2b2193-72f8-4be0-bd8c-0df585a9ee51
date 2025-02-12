using System;
using static System.Console;
using System.Globalization;
class DoubleDecimalTest
{
	static void Main()
	{
		double a = 1234567899876543212345678987654321.9;
		// display error for out of range
		decimal b = 1234567899876543212345678987654321.9M;
		
		Console.WriteLine(a);
		Console.WriteLine(b);
	}
}
