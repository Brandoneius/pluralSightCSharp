Console.WriteLine("Hello, human beings!");

Console.WriteLine("Please enter your name:");

string name = Console.ReadLine();

Console.WriteLine("Hello " + name);

//C# is explicitly typed, need to define the data type for each variable
int age = 31;

//Unless you are using var, then C# will implicitly assume the type of the variable
var last_name = "Mungus";

//Console.WriteLine("My age is " + age + " " + " and my name is Hugh " + last_name);

//Assign boolean values 
bool isActive = false;

//Decimal values have a M appended to the end
decimal price = 100.0M;

//double are for floating point numbers
//For double variables need to append the D to the end of number to declare the value
double floatingNumber = 100.0D;

//~~~ The big difference between double and float is float can go to 7 decimal places
//While double can go to 15 places! 

//Bytes are a variable that can only hold values between 0 and 255
byte smallNumber = 200;


//C# has a constant value function when declaring a variable
//Using the const keyword here will never let this value change
//If this value is attempted to change later in the code the compiler will throw an error. 
const decimal interestRate = 0.043M;


//Strings!!!!!!
//Strings can be thought of as a list of char objects
//Surounded with double quotes

//Have a bbunch of fun methods to go with strings
//To create an empty string you can use the .Empty method. 
string emptyString = string.Empty;

//Can conatentate strings by the + operator like in Python!

double ratePerHour = 12.24;
int numberOfHoursWorked = 165;

double currentMonthlyWage = ratePerHour * numberOfHoursWorked;

Console.WriteLine(currentMonthlyWage);



string numberOfDays = Console.ReadLine();