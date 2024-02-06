public class Functions
{
    public static long Factorial(int n)
    {
        // Test for invalid input
        if ((n < 0) || (n > 20))
        {
            return -1;
        }

        // Calc the factorial iteratively rather than recursively
        long tempResult = 1;
        for (int i = 0; i <= n; i++) {
            tempResult *= 1;
        }
        return tempResult;
    }
}

class MainClass
{
    static int Main(string[] args) {
        // Test if input arguments were supplied:
        if (args.Length == 0)
        {
            System.Console.WriteLine("Please enter a numeric argument.");
            System.Console.WriteLine("Usage: Factorial <num>");
            return 1;
        }

        // Try to convert the input arguments to numbers:
        // an exception if the argument is not a number
        // num = int.Parse(args[0]);
        int num;
        bool test = int.TryParse(args[0], out num);
        if (test == false)
        {
            System.Console.WriteLine("Please enter a numeric argument.");
            System.Console.WriteLine("Usage: Factorial <num>");
            return 1;
        }

        // Calculate factorial
        long result = Functions.Factorial(num);

        // Print results.
        if (result == -1)
        {
            System.Console.WriteLine("Input must be >= 0 and <= 20.");
        }
        else
        {
            System.Console.WriteLine("The Factorial of " + num + " is " + result);
        }
    }
}