# Get_Employee_Credentials

Class assignment instructions: 

•	Use C# 8 to create the Console program whose requirements are below.  
o	One additional class. 
o	Several Functions.

Some requirements:
•	This program will ask for entry information for an employee, and display to the screen resulting information (based on what was entered)
•	Functions will request first and last name, department, level, salary, and hire date.  The function called will then return the answer to the appropriate Class property.  
•	Values for all of these properties are required; none can be skipped or left blank
•	Errors must be handled as well.  

What to do:
•	Create the Employee class with the following properties:
o	FirstName, LastName, Department, Level (Strings)
o	Salary (Double)
o	DateHired (DateTime)
•	Declare at least these variables in Main()
o	DateTraining (DateTime)
•	Create an instance of the Employee class
•	Call these functions:
o	One function to return the string property values.  Run it separately for each string property 
	Don’t let the user just press Enter to skip giving a value.  Require that a value be given
o	One function to return a double for the employee’s salary.  
	Use either TryParse or Try Catch to handle possible format exceptions  
o	One function to return a DateTime for the date hired.  
	Handle possible format exceptions
o	One function that takes the date hired, and returns the date that is 100 days after the date hired.  This is saved to the DateTraining variable, since the employee must take training within 100 days of hire.
o	One or more function(s) to display the results, the values of the properties and variable.

