
using System;
using System.IO;

namespace CSharpRecap
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Add two numbers
            Console.WriteLine(AddTwoNumbers(3, 4));

            // 2. Check even
            Console.WriteLine(IsEven(6));

            // 3. Greet
            GreetUser("Samir");

            // 4. Max
            Console.WriteLine(Max(4.5, 7.3));

            // 5. Factorial
            Console.WriteLine(Factorial(5));

            // 6. For loop 1 to 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // 7. While loop even 2 to 20
            int i2 = 2;
            while (i2 <= 20)
            {
                Console.WriteLine(i2);
                i2 += 2;
            }

            // 8. Do-while password input
            string password;
            do
            {
                Console.Write("Enter password: ");
                password = Console.ReadLine();
            } while (password != "admin");

            // 9. Sum 1 to 100
            int sum = 0;
            for (int j = 1; j <= 100; j++)
            {
                sum += j;
            }
            Console.WriteLine("Sum: " + sum);

            // 10. Print array names
            string[] names = { "Ali", "Mona", "Samir" };
            foreach (string person in names)
            {
                Console.WriteLine(person);
            }

            // 11. Array first and last
            int[] arr = { 5, 10, 15, 20 };
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[arr.Length - 1]);

            // 12. Max in array
            int max = arr[0];
            foreach (int num in arr)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("Max: " + max);

            // 13. Input 3 names, print reverse
            string[] users = new string[3];
            for (int k = 0; k < 3; k++)
            {
                users[k] = Console.ReadLine();
            }
            Array.Reverse(users);
            foreach (string item in users)
            {
                Console.WriteLine(item);
            }

            // 14. Sum array
            int[] nums = { 3, 6, 9, 12 };
            int total = 0;
            foreach (int n in nums)
            {
                total += n;
            }
            Console.WriteLine("Sum: " + total);

            // 15. Count odd
            int[] myNums = { 1, 4, 5, 7, 8 };
            int oddCount = 0;
            foreach (int n in myNums)
            {
                if (n % 2 != 0)
                {
                    oddCount++;
                }
            }
            Console.WriteLine("Odd count: " + oddCount);

            // 16. Format exception
            try
            {
                int x = int.Parse("abc");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format.");
            }

            // 17. Divide by zero
            try
            {
                int a = 5, b = 0;
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            // 18. File check
            try
            {
                if (!File.Exists("file.txt"))
                {
                    throw new FileNotFoundException();
                }
                Console.WriteLine("File found.");
            }
            catch
            {
                Console.WriteLine("File not found.");
            }

            // 19. Finally block
            try
            {
                Console.WriteLine("Trying...");
            }
            finally
            {
                Console.WriteLine("Finished");
            }

            // 20. User input try-catch
            try
            {
                Console.Write("Enter number: ");
                int number = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input.");
            }

            // 21. Declare and print
            string nickname = "Samir";
            int age1 = 25;
            double height = 1.78;
            Console.WriteLine("Name: " + nickname + ", Age: " + age1 + ", Height: " + height);

            // 22. Age input
            Console.Write("Enter your age: ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("You are " + userAge + " years old");

            // 23. Area of circle
            const double Pi = 3.14159;
            double radius = 3;
            Console.WriteLine("Area = " + (Pi * radius * radius));

            // 24. Float sum
            float f1 = 2.5f, f2 = 3.4f;
            Console.WriteLine("Sum = " + (f1 + f2).ToString("0.00"));

            // 25. Type of var
            var message = "Hello, Samir";
            Console.WriteLine(message.GetType());

            // 26. Math ops
            int n1 = 10, n2 = 5;
            Console.WriteLine("Sum: " + (n1 + n2));
            Console.WriteLine("Diff: " + (n1 - n2));
            Console.WriteLine("Product: " + (n1 * n2));
            Console.WriteLine("Quotient: " + (n1 / n2));

            // 27. Logic AND
            int numCheck = 12;
            if (numCheck > 10 && numCheck % 2 == 0)
            {
                Console.WriteLine("Number is greater than 10 and even.");
            }

            // 28. Ternary age
            int myAge = 17;
            string status;
            if (myAge >= 18)
            {
                status = "Adult";
            }
            else
            {
                status = "Minor";
            }
            Console.WriteLine(status);

            // 29. Increment
            int x1 = 5;
            x1++;
            Console.WriteLine("x: " + x1);

            // 30. String compare
            string s1 = "hello", s2 = "hello";
            if (s1 == s2)
            {
                Console.WriteLine("Strings equal.");
            }

            // 31. Local variable scope
            LocalScopeExample();

            // 32. Greet user input
            Console.Write("Enter name: ");
            string username = Console.ReadLine();
            Console.WriteLine("Welcome, " + username);

            // 33. Sum two user numbers
            Console.Write("Enter first number: ");
            int numA = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum = " + (numA + numB));

            // 34. Favorite color
            Console.Write("Fav color? ");
            string color = Console.ReadLine();
            Console.WriteLine("Your favorite color is " + color);

            // 35. Same line output
            Console.Write("Hello ");
            Console.Write("World");

            // 36. Read key
            Console.WriteLine("\nPress any key: ");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine("\nYou pressed: " + key.KeyChar);

            // 37. Write file
            File.WriteAllText("welcome.txt", "Welcome to C#!");

            // 38. Check file
            if (File.Exists("data.txt"))
            {
                Console.WriteLine("File exists.");
            }
            else
            {
                Console.WriteLine("Not found.");
            }

            // 39. Append to log
            File.AppendAllText("log.txt", "New log entry\n");

            // 40. Read file
            if (File.Exists("notes.txt"))
            {
                Console.WriteLine(File.ReadAllText("notes.txt"));
            }

            // 41. Read names with index
            if (File.Exists("names.txt"))
            {
                string[] lines = File.ReadAllLines("names.txt");
                for (int z = 0; z < lines.Length; z++)
                {
                    Console.WriteLine((z + 1) + ": " + lines[z]);
                }
            }

            // 42. Hello C#
            Console.WriteLine("Hello, C#");

            // 43. Print variables
            string myName = "Samir";
            int age = 22;
            bool isDev = true;
            Console.WriteLine("Name: " + myName + ", Age: " + age + ", Developer: " + isDev);

            // 44. Loop 1-5
            for (int k = 1; k <= 5; k++)
            {
                Console.WriteLine(k);
            }

            // 45. Check number
            int numberCheck = -2;
            if (numberCheck > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (numberCheck < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }

        static int AddTwoNumbers(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void GreetUser(string name)
        {
            Console.WriteLine("Welcome, " + name + "!");
        }

        static double Max(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static void LocalScopeExample()
        {
            int value = 10;
            Console.WriteLine("Value is: " + value);
        }
    }
}
