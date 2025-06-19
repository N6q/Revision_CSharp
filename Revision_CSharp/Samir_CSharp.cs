// 1. Create a function that takes 2 integers and returns their sum
int AddTwoNumbers(int a, int b)
{
    return a + b; // Adds two numbers and returns result
}

// 2. Write a method that returns true if a number is even
bool IsEven(int number)
{
    return number % 2 == 0; // Even numbers have no remainder when divided by 2
}

// 3. Print a welcome message with user's name
void GreetUser(string name)
{
    Console.WriteLine("Welcome, " + name + "!"); // Displays custom greeting
}

// 4. Define a method that returns the larger of two double values
double Max(double a, double b)
{
    return (a > b) ? a : b; // Ternary operator to return the greater value
}

// 5. Recursive method to calculate factorial
int Factorial(int n)
{
    if (n <= 1) return 1;
    return n * Factorial(n - 1); // Calls itself to multiply decreasing values
}

// 6. Use for loop to print numbers 1 to 10
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i); // Outputs current value of i
}

// 7. Use while loop to print even numbers from 2 to 20
int i = 2;
while (i <= 20)
{
    Console.WriteLine(i); // Outputs even numbers
    i += 2;
}

// 8. Use do-while loop to ask for password until 'admin' is entered
string password;
do
{
    Console.Write("Enter password: ");
    password = Console.ReadLine();
} while (password != "admin");

// 9. Sum numbers from 1 to 100 using loop
int sum = 0;
for (int j = 1; j <= 100; j++)
{
    sum += j; // Accumulates sum
}
Console.WriteLine("Sum: " + sum);

// 10. Print each name in a string array using foreach
string[] names = { "Ali", "Mona", "Samir" };
foreach (string name in names)
{
    Console.WriteLine(name); // Iterates over array items
}

// 11. Create an array {5,10,15,20} and print first and last elements
int[] arr = { 5, 10, 15, 20 };
Console.WriteLine(arr[0]); // First element
Console.WriteLine(arr[arr.Length - 1]); // Last element

// 12. Find the max value in an int array
int max = arr[0];
foreach (int num in arr)
{
    if (num > max) max = num; // Check each number
}
Console.WriteLine("Max: " + max);

// 13. Store 3 names from user input in an array, print in reverse
string[] users = new string[3];
for (int i = 0; i < 3; i++)
{
    users[i] = Console.ReadLine(); // Take user input
}
Array.Reverse(users);
foreach (string name in users)
{
    Console.WriteLine(name); // Print in reverse order
}

// 14. Sum all elements in array {3,6,9,12}
int[] nums = { 3, 6, 9, 12 };
int total = 0;
foreach (int n in nums)
{
    total += n; // Add each element
}
Console.WriteLine("Sum: " + total);

// 15. Count how many odd numbers are in a user-defined array
int[] myNums = { 1, 4, 5, 7, 8 };
int oddCount = 0;
foreach (int n in myNums)
{
    if (n % 2 != 0) oddCount++; // Check for odd
}
Console.WriteLine("Odd numbers count: " + oddCount);


// 16. Catch format exception when parsing an int
try
{
    int x = int.Parse("abc"); // This will fail
}
catch (FormatException)
{
    Console.WriteLine("Invalid number format.");
}

// 17. Handle divide-by-zero exception
try
{
    int a = 5, b = 0;
    Console.WriteLine(a / b); // Division by zero
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero.");
}

// 18. Use try-catch to check if file exists before reading
try
{
    if (!File.Exists("file.txt"))
        throw new FileNotFoundException();
    Console.WriteLine("File found.");
}
catch
{
    Console.WriteLine("File not found.");
}

// 19. Demonstrate finally block that always prints
try
{
    Console.WriteLine("Trying...");
}
finally
{
    Console.WriteLine("Finished"); // This always runs
}

// 20. Wrap user input in try-catch to validate number entry
try
{
    Console.Write("Enter number: ");
    int number = int.Parse(Console.ReadLine());
}
catch
{
    Console.WriteLine("Invalid input.");
}

// 21. Declare and print variables: name (string), age (int), height (double)
string name = "Samir";
int age = 25;
double height = 1.78;
Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Height: " + height);

// 22. Ask for age and print 'You are X years old'
Console.Write("Enter your age: ");
int userAge = int.Parse(Console.ReadLine());
Console.WriteLine("You are " + userAge + " years old");

// 23. Calculate area of a circle using const double Pi
const double Pi = 3.14159;
double radius = 3;
double area = Pi * radius * radius;
Console.WriteLine("Area = " + area);

// 24. Add two float numbers and print result formatted to 2 decimals
float f1 = 2.5f, f2 = 3.4f;
float fSum = f1 + f2;
Console.WriteLine("Sum = " + fSum.ToString("0.00"));

// 25. Use var with string value and print its type
var message = "Hello, Samir";
Console.WriteLine(message.GetType()); // Shows the type (System.String)

// 26. Input two numbers, show sum, difference, product, and quotient
int a = 10, b = 5;
Console.WriteLine("Sum: " + (a + b));
Console.WriteLine("Difference: " + (a - b));
Console.WriteLine("Product: " + (a * b));
Console.WriteLine("Quotient: " + (a / b));

// 27. Check if number is >10 and even using logical AND
int number = 12;
if (number > 10 && number % 2 == 0)
{
    Console.WriteLine("Number is greater than 10 and even.");
}

// 28. Use ternary operator to check if age >= 18 (Adult/Minor)
int myAge = 17;
string status = (myAge >= 18) ? "Adult" : "Minor";
Console.WriteLine(status);

// 29. Increment x = 5 using ++ and print result
int x = 5;
x++;
Console.WriteLine("Incremented x: " + x);

// 30. Compare two strings and check if they are equal using ==
string s1 = "hello";
string s2 = "hello";
if (s1 == s2)
{
    Console.WriteLine("Strings are equal.");
}

// 31. Create a class with private field and public Set/Get methods
class Person
{
    private string name; // Only accessible inside this class

    public void SetName(string newName)
    {
        name = newName;
    }

    public string GetName()
    {
        return name;
    }
}

// 32. Use a public method that calls a private method inside the class
class MyClass
{
    public void Show()
    {
        Print(); // Calling private method from public one
    }

    private void Print()
    {
        Console.WriteLine("Hello from private method");
    }
}

// 33. Track method calls using static field
class Counter
{
    public static int count = 0;

    public Counter()
    {
        count++; // Shared across all instances
    }
}

// 34. Use protected method in base class and call from derived class
class BaseClass
{
    protected void Hello()
    {
        Console.WriteLine("Hello from base");
    }
}

class DerivedClass : BaseClass
{
    public void CallHello()
    {
        Hello(); // Accessible because it's protected
    }
}

// 35. Demonstrate scope of a local variable inside a method
void LocalScopeExample()
{
    int value = 10; // Only exists in this method
    Console.WriteLine(value);
}

// 36. Read user name using Console.ReadLine() and greet them
Console.Write("Enter your name: ");
string user = Console.ReadLine();
Console.WriteLine("Welcome, " + user);

// 37. Read two numbers from user and display their sum
Console.Write("Enter first number: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Sum = " + (n1 + n2));

// 38. Ask for favorite color and print using string interpolation
Console.Write("What is your favorite color? ");
string color = Console.ReadLine();
Console.WriteLine($"Your favorite color is {color}");

// 39. Print two messages on the same line using Console.Write()
Console.Write("Hello ");
Console.Write("World");

// 40. Read a key using Console.ReadKey() and display it
Console.WriteLine("\nPress any key: ");
ConsoleKeyInfo key = Console.ReadKey();
Console.WriteLine($"\nYou pressed: {key.KeyChar}");

// 41. Create a text file and write a welcome message
File.WriteAllText("welcome.txt", "Welcome to C#!");

// 42. Check if a file exists and print appropriate message
if (File.Exists("data.txt"))
    Console.WriteLine("File exists.");
else
    Console.WriteLine("File not found.");

// 43. Append a line to log.txt, create if missing
File.AppendAllText("log.txt", "New log entry\n");

// 44. Read and print contents of notes.txt
string content = File.ReadAllText("notes.txt");
Console.WriteLine(content);

// 45. Read names from file and print with line numbers
string[] lines = File.ReadAllLines("names.txt");
for (int i = 0; i < lines.Length; i++)
{
    Console.WriteLine($"{i + 1}: {lines[i]}");
}

// 46. Write Main() that prints 'Hello, C#'
static void Main(string[] args)
{
    Console.WriteLine("Hello, C#");
}

// 47. Declare and print string, int, bool variables
string name = "Samir";
int age = 22;
bool isDev = true;
Console.WriteLine($"Name: {name}, Age: {age}, Developer: {isDev}");

// 48. Use a for loop to print numbers 1 to 5
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

// 49. Check if number is positive, negative or zero using if-else
int number = -2;
if (number > 0)
    Console.WriteLine("Positive");
else if (number < 0)
    Console.WriteLine("Negative");
else
    Console.WriteLine("Zero");

// 50. Create class Car with Drive() method, call it from Main()
class Car
{
    public void Drive()
    {
        Console.WriteLine("Driving...");
    }
}

Car myCar = new Car();
myCar.Drive();
