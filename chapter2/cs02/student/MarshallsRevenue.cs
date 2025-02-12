using System;
using static System.Console;
using System.Globalization;
using System.Runtime.CompilerServices;
class MarshallsRevenue
{
   static void Main()
   {
    // prices for murals
    double interior = 500;
    double exterior = 750;

    // collect data
    WriteLine("```");
    Write("Enter number of interior murals scheduled >> ");
    double interiorMurals = Convert.ToDouble(ReadLine());
    Write("Enter number of exterior murals scheduled >> ");
    double exteriorMurals = Convert.ToDouble(ReadLine());
    
    // calculate revenue
    double interiorRevenue = interiorMurals * interior;
    double exteriorRevenue = exteriorMurals * exterior;
    double totalRevenue = interiorRevenue + exteriorRevenue;

    // check for more interior murals
    bool moreInterior = interiorMurals > exteriorMurals;
   
    // output
    WriteLine("{0} interior murals are scheduled at {1} each for a total of {2}", interiorMurals, interior.ToString("C", CultureInfo.GetCultureInfo("en-US")), interiorRevenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    WriteLine("{0} exterior murals are scheduled at {1} each for a total of {2}", exteriorMurals, exterior.ToString("C", CultureInfo.GetCultureInfo("en-US")), exteriorRevenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    WriteLine("Total revenue expected is {0}", totalRevenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    WriteLine("It is {0} that there are more interior murals scheduled than exterior ones.", moreInterior);
    WriteLine("```");
  }
}
