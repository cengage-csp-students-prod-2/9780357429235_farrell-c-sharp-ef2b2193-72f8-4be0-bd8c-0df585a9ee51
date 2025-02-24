using System;
using static System.Console;
using System.Globalization;
class Twitter
{
	static void Main()
	{
		Write("Please enter your username >>");
		string username = ReadLine();
		if (username.Length > 140){
			Write("The message is too long");
		}
		else{
			Write("The message is okay");
		}
	}
}