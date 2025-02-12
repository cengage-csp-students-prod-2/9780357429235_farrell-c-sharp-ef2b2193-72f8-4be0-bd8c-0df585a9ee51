using System;
using static System.Console;
using System.Globalization;
class Eggs
{
	static void Main()
	{
		int chicken1 = 9;
        int chicken2 = 7;
        int chicken3 = 6;
        int chicken4 = 105;

        int totalEggs = chicken1 + chicken2 + chicken3 + chicken4;
        int dozen = totalEggs / 12;
        int eggLeft = totalEggs % 12;

        WriteLine("{0} eggs is {1} dozen and {2} eggs", totalEggs, dozen, eggLeft);
	}
}
