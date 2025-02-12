using System;
using static System.Console;
using System.Globalization;
class MakeChange
{
	static void Main()
	{
		int dollar = 113;
        int twenty = dollar / 20;
        int dollarLeft = dollar % 20;

        int ten = dollarLeft / 10;
        dollarLeft = dollarLeft % 10;

        int five = dollarLeft / 5;
        dollarLeft = dollarLeft % 5;
        
        int one = dollarLeft / 1;

        WriteLine("twenties: {0} tens: {1} fives: {2} ones: {3}", twenty, ten, five, one);
	}
}
