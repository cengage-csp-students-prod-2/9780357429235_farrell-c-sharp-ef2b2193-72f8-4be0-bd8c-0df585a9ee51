using System;
using static System.Console;
using System.Globalization;
class TestsInteractive
{
	static void Main()
	{
		Write("Enter test score 1 >> ");
        int score1 = int.Parse(ReadLine());
        Write("Enter test score 2 >> ");
        int score2 = int.Parse(ReadLine());
        Write("Enter test score 3 >> ");
        int score3 = int.Parse(ReadLine());
        Write("Enter test score 4 >> ");
        int score4 = int.Parse(ReadLine());
        Write("Enter test score 5 >> ");
        int score5 = int.Parse(ReadLine());
        Write("Enter test score 6 >> ");
        int score6 = int.Parse(ReadLine());
        Write("Enter test score 7 >> ");
        int score7 = int.Parse(ReadLine());
        Write("Enter test score 8 >> ");
        int score8 = int.Parse(ReadLine());

        double average = (score1 + score2 + score3 + score4 + score5 + score6 + score7 + score8) / 8.0;
        WriteLine("The average test scores is {0}", average.ToString("0.00"));
	}
}
