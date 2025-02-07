using System;

public class FibonacciGenerator
{
    public static void PrintFibonacciSeries(int n)
    {
        // Input validation: Check for non-negative input
        if (n < 0)
        {
            throw new ArgumentException("Input must be a non-negative integer.");
        }

        // Handle base cases: n = 0 and n = 1
        if (n == 0)
        {
            return; // Nothing to print
        }

        if (n == 1)
        {
            Console.WriteLine(0);
            return;
        }

        // Initialize the first two Fibonacci numbers
        int a = 0;
        int b = 1;

        Console.WriteLine(a);
        Console.WriteLine(b);

        // Generate the remaining Fibonacci numbers iteratively
        for (int i = 2; i < n; i++)
        {
            int next = a + b;
            Console.WriteLine(next);
            a = b;
            b = next;
        }
    }
}