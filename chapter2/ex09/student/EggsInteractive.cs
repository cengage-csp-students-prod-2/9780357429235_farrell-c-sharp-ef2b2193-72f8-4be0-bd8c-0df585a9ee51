using System;
using static System.Console;
using System.Globalization;
class EggsInteractive
{
	static void Main()
	{
        WriteLine("Enter the number of eggs for chicken 1 >> ");
		int chicken1 = int.Parse(ReadLine());
        WriteLine("Enter the number of eggs for chicken 2 >> ");
        int chicken2 = int.Parse(ReadLine());
        WriteLine("Enter the number of eggs for chicken 3 >> ");
        int chicken3 = int.Parse(ReadLine());
        WriteLine("Enter the number of eggs for chicken 4 >> ");
        int chicken4 = int.Parse(ReadLine());

        int totalEggs = chicken1 + chicken2 + chicken3 + chicken4;
        int dozen = totalEggs / 12;
        int eggLeft = totalEggs % 12;

        WriteLine("{0} eggs is {1} dozen and {2} eggs", totalEggs, dozen, eggLeft);
	}
}
