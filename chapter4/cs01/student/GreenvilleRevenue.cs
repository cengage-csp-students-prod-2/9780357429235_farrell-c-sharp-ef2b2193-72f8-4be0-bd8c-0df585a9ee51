using System;
using static System.Console;
using System.Globalization;
class GreenvilleRevenue
{
   static void Main()
   {
      const double entraceFee = 25.00;

       // collect data
     Write("Enter number of contestants last year >> ");
     int contestantsLastYear = Convert.ToInt32(ReadLine());
     Write("Enter number of contestants this year >> ");
     int contestantsThisYear = Convert.ToInt32(ReadLine());
    
    // calculate revenue
    double revenueThisYear = contestantsThisYear * entraceFee;
    double revenueLastYear = contestantsLastYear * entraceFee;
    bool revenueIncreased = revenueThisYear > revenueLastYear;
    
   // output
   if (contestantsLastYear <= contestantsThisYear/2)
   {
      WriteLine("The competition is more than twice as big this year!");
   }
   else if (contestantsLastYear < contestantsThisYear)
   {
      WriteLine("The competition is bigger than ever!");
   }
   else
   {
      WriteLine(" A tighter race this year! Come out and cast your vote!");
   }


   WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants", contestantsLastYear, contestantsThisYear);
    WriteLine("Revenue expected this year is {0}", revenueThisYear.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    WriteLine("It is {0} that this year's competition is bigger than last year's", revenueIncreased);
}
}
