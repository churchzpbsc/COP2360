using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        try
        {
            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

            int result = Divide(num1, num2);
            Console.WriteLine($"The result of {num1} divided by {num2} is: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: One or both of the inputs are not valid integers.");
            Console.WriteLine($"Detailed error message: Both of the inputs cannot be float or string entries.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            Console.WriteLine($"Detailed error message: The second input, the denominator, cannot be a zero.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine($"Detailed error message: The input entered is too large and outside of range.");
        }
    }

    private static int Divide(int a, int b)
    {
        return a / b;
    }
}
