using System;
using static System.Console;
using System.Globalization;
class PigLatin
{
	static void Main()
	{
		Write("Enter a word >> ");
        string word = ReadLine();

        string firstLetter = word.Substring(0, 1);
        string WordLeft = word.Substring(1, word.Length - 1);
        
        WriteLine("{0} in Pig Latin is {1}{2}ay", word, WordLeft, firstLetter);
	}
}
