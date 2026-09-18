using System.ComponentModel;

Console.WriteLine("Hello, World!");

//Input Methods
Console.Read(); // Returns/Prints ASCII Value

Console.ReadLine(); //To Make Read Work

Console.ReadKey(); //Waits for key input before it goes ahead.

//Output Methods
Console.Write("Hello");
Console.WriteLine("Hello Worlder!");

//DataTypes
string stringy = "Hi";
char charter = 'B';
short shorty = 0;
long longer = 120;
int inter = 12;
float floater = 5.0f;
double doble = 3.1415126;
bool tamaBa = true;

//String Operations
Console.WriteLine("Hello " + "World!");
string concatText = "This is a";
concatText += "continuation of the sentence";
Console.WriteLine(concatText);
Console.ReadKey();
Console.WriteLine();

//Interpolation - Formatting
string userName = "Gabriel";
string date = DateTime.Today.ToShortDateString();
string str = $"Hello {userName}! Today is {date}";

int hoursSlept = 5;
string welcomeText = String.Format("My name is {0} {1} but you can call me {0}! As of {2:MMM d}, I have slept for only {3} hours...", "Luis", "Andrei", DateTime.Today, hoursSlept);
Console.WriteLine(welcomeText);
Console.ReadKey();
Console.WriteLine();

//Escape Character
Console.WriteLine("\" You can see the double quotation mark because of the back slash");
Console.WriteLine("By using a \\ on n, I can make a breakine. \n \n I put two on");

//Unique Operations
int integerNumberOp = 5;
int integerNumberDivisor = 2;
Console.WriteLine((integerNumberOp/integerNumberDivisor).ToString() + " is integer 5 divided by 2");

float floatNumberOp = 5f;
float floatNumberDivisor = 2f;
Console.WriteLine((floatNumberOp / floatNumberDivisor).ToString() + " is integer 5 divided by 2");

int incrementEx = 5;
Console.WriteLine($"The base increment is {incrementEx}");
Console.WriteLine($"The increment with ++ before it is {++incrementEx}"); // ++x, x = x+1, x = 2
Console.WriteLine($"The increment with ++ after it is {incrementEx++}"); // x++, x = 1, x = x+1

//Lists
List<double> numGrades =  new List<double>();
numGrades.Add(99.9001);
Console.WriteLine(numGrades[0]);
numGrades.Remove(99.9001); //Removes 99.9001 from the list

//For Loop
