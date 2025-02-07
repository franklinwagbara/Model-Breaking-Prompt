using NUnit.Framework;
using System;
using System.IO;

public class FibonacciGeneratorTests
{
    [Test]
    public void PrintFibonacciSeries_ValidInput_PrintsCorrectSeries()
    {
        using (var consoleOutput = new StringWriter())
        {
            Console.SetOut(consoleOutput); // Redirect console output to capture it

            FibonacciGenerator.PrintFibonacciSeries(10);

            string expectedOutput = "0\r\n1\r\n1\r\n2\r\n3\r\n5\r\n8\r\n13\r\n21\r\n34\r\n";
            Assert.That(consoleOutput.ToString(), Is.EqualTo(expectedOutput));
        }
    }

    [Test]
    public void PrintFibonacciSeries_ZeroInput_PrintsNothing()
    {
        using (var consoleOutput = new StringWriter())
        {
            Console.SetOut(consoleOutput);

            FibonacciGenerator.PrintFibonacciSeries(0);

            Assert.That(consoleOutput.ToString(), Is.EqualTo(""));
        }
    }

    [Test]
    public void PrintFibonacciSeries_OneInput_PrintsZero()
    {
        using (var consoleOutput = new StringWriter())
        {
            Console.SetOut(consoleOutput);

            FibonacciGenerator.PrintFibonacciSeries(1);

            Assert.That(consoleOutput.ToString(), Is.EqualTo("0\r\n"));
        }
    }

    [Test]
    public void PrintFibonacciSeries_NegativeInput_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => FibonacciGenerator.PrintFibonacciSeries(-5));
    }
}