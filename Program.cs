using System;

namespace ClassMethodAssignment
{
    // A regular (non-static) class that holds the math methods
    class MathOperations
    {
        // 1. A void method that divides the number passed to it by 2
        //    and outputs the integer result to the screen
        public void DivideByTwo(int number)
        {
            // Integer division: the decimal part is dropped (for example 7 / 2 = 3)
            int result = number / 2;

            // Output the result to the screen
            Console.WriteLine(number + " divided by 2 is: " + result);
        }

        // 5. OVERLOADED method: same name as above, but it takes a double instead of an int.
        //    C# chooses which version to run based on the type of the argument.
        public void DivideByTwo(double number)
        {
            // Decimal division: the decimal part is kept (for example 7.0 / 2 = 3.5)
            double result = number / 2;

            // Output the result to the screen
            Console.WriteLine(number + " divided by 2 is: " + result);
        }

        // 4. A method with OUTPUT parameters.
        //    'out' parameters let a method send back more than one value to the caller.
        public void DivideWithRemainder(int number, out int quotient, out int remainder)
        {
            // How many whole times 2 fits into the number
            quotient = number / 2;

            // What is left over after dividing by 2 (always 0 or 1)
            remainder = number % 2;
        }
    }

    // 6. A STATIC class: it cannot be instantiated with 'new'.
    //    Its members are used directly through the class name.
    static class MathInfo
    {
        // A static method that displays a short message
        public static void ShowInfo()
        {
            Console.WriteLine("MathInfo is a static class - no object is needed to use it.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 2. Instantiate the MathOperations class (create an object from it)
            MathOperations mathOperations = new MathOperations();

            // 3. Ask the user to enter a whole number
            Console.WriteLine("Please enter a whole number:");

            // Read the input as text and convert it to an integer
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Call the method on the user's number; it displays the number divided by 2
            mathOperations.DivideByTwo(userNumber);

            // Declare two variables that will receive the output parameter values
            int quotient;
            int remainder;

            // Call the method with output parameters; it fills quotient and remainder
            mathOperations.DivideWithRemainder(userNumber, out quotient, out remainder);

            // Display the values returned through the output parameters
            Console.WriteLine("Using output parameters: quotient = " + quotient + ", remainder = " + remainder);

            // Call the overloaded version by passing a double instead of an int
            Console.WriteLine("Calling the overloaded method with a double:");
            mathOperations.DivideByTwo((double)userNumber);

            // Call the static class method directly through the class name (no 'new' needed)
            MathInfo.ShowInfo();

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}