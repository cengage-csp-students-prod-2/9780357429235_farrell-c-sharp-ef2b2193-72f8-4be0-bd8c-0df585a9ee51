Create a program named *ConferencesDemo* for a hotel that hosts business
conferences. Allows a user to enter data about five `Conference` objects and then
displays them in order of attendance from smallest to largest. 

The `Conference` class contains fields for the following:
* `group` - The group name (as a `string`)
* `date` - The starting date (as a `string`)
*  `attendees` - The number of attendees (as an `int`)
  
Include properties for each field. Use default, empty constructor.

Also, include an `IComparable.CompareTo()` method so that `Conference` objects can be sorted in order from least to greatest `attendees`.

Your output for each conference should match the following:

````
NAME Conference starts on DATE and has ATTENDEES attendees
````


