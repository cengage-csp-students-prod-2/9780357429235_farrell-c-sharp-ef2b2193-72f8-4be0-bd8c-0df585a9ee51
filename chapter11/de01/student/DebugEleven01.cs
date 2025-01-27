// Handles a Format Exception if user does not enter a number
using System;
using static System.Console;
using System.Globalization;
class DebugEleven01
{
   static void Main()
   {
      double salary;
      string salVal;
      bool isValidSalary;
      while(!isValidSalary)
      {
         try
            Write("Enter an employee's salary ");
            salVal = ReadLine();
            salary = Convert.ToDouble(salVal);
            isValidSalary = true;
         catch(Formatexception)
         {
            WriteLine("You must enter a number for the salary.");
         }
      }
      WriteLine("The salary {0} is valid", salary.ToString("C2", CultureInfo.GetCultureInfo("en-US")));
   }
}
