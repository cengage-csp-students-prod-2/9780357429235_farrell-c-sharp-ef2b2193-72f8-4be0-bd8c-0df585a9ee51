using System;
using static System.Console;
using System.Globalization;
class GreenvilleRevenue
{
   static void Main()
   {
    // collect data
     Write("Enter number of contestants last year >> ");
     int contestantsLastYear = Convert.ToInt32(ReadLine());
     Write("Enter number of contestants this year >> ");
     int contestantsThisYear = Convert.ToInt32(ReadLine());
    
    // calculate revenue
    double revenueThisYear = contestantsThisYear * 25;
    double revenueLastYear = contestantsLastYear * 25;
    bool revenueIncreased = revenueThisYear > revenueLastYear;
    
   // output
    WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants", contestantsLastYear, contestantsThisYear);
    WriteLine("Revenue expected this year is {0}", revenueThisYear.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    WriteLine("It is {0} that this year's competition is bigger than last year's", revenueIncreased);
   }
}
