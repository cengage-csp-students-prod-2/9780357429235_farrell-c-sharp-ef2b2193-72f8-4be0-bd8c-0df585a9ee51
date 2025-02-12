using System;
using static System.Console;
using System.Globalization;
class Planets
{
    enum SolarPlanet
        {
            MERCURY = 1,
            VENUS = 2,
            EARTH = 3,
            MARS = 4,
            JUPITER = 5,
            SATURN = 6,
            URANUS = 7,
            NEPTUNE = 8
        }
	static void Main()
	{
		Write("Enter a planet number >> ");
        int planetNumber = int.Parse(ReadLine());
        
        WriteLine("{0} is {1} planet(s) from the sun ", (SolarPlanet)planetNumber, planetNumber);
	}
}
