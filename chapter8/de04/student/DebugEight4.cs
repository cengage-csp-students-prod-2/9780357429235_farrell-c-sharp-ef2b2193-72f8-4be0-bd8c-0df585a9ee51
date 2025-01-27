// Program demonstrates overloaded methods
// that display an int, an amount of money, or a string
// decorated with an argument character
// or a default character 'X'
using System;
using static System.Console;
using System.Globalization;
class DebugEight4
{
   static void Main()
   {
       FancyDisplay(33);
       FancyDisplay(44, "@");
       FancyDisplay(55.55);
       FancyDisplay(77.77, '*');
       FancyDisplay("hello");
       FancyDisplay("goodbye", '#');
   }
   public static void FancyDisplay(int num, char decoration = 'X')
   {
      WriteLine("{0}{1}{2}  {1}  {0}{1}{2}\n",
         decoration, num); 
   }
   public static void FancyDisply(double num, char decoration = 'X')
   {
      WriteLine("{0}{0}{0}    {0}{0}{0}\n",
         decoration, num.ToString("C", CultureInfo.GetCultureInfo("en-US"))); 
   }
   public static void FancyDisplay(word, char decoration = 'X')
   {
      WriteLine("{0}{0}{0}  {1}  {1}{0}{0}\n",
         decoration, word); 
   }

}
