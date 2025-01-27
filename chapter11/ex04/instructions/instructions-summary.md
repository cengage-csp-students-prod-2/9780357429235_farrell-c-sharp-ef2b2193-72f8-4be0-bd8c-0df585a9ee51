Write the program `StudentGradeDemo` that attempts to create several valid and invalid `ReportCard` objects. Immediately after each instantiation attempt, handle any thrown exceptions by displaying an error message. 

Create a `ReportCard` class with four fields for a student name, a numeric midterm grade, a numeric final exam grade, and letter grade. The `ReportCard` constructor requires values for the name (`string) and two numeric grades (midterm and final as `int`) and determines the letter grade. Upon construction, throw an `ArgumentException` if the midterm or final exam grade is less than 0 or more than 100. 

The letter grade is based on the arithmetic average of the midterm and final exams using a grading scale of **A** for an average of **90** to **100**, **B** for **80** to **90**, **C** for **70** to **80**, **D** for **60** to **70**, and **F** for an average below **60**. Display all the data if the instantiation is successful.

Use the `Main()` method to test your code. 

