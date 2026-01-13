using CodeAcademy_Tasks.Interfaces;
using System.Numerics;
using System.Security.AccessControl;

namespace CodeAcademy_Tasks.Implementations;

public class Calculation : ICalculation
{
    public void Difference(int num1, int num2)
    {
        int difference = num1 - num2;
        Console.WriteLine($"Result for differ operation : {difference}");
    }

    public void Divide(int num1, int num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine($"Division by 0 is not allowed");
            return;
        }
        int division = num1 / num2;
        Console.WriteLine($"Result for divide operation : {division}");
    }

    public void Multiply(int num1, int num2)
    {
        int multiply = num1 * num2;
        Console.WriteLine($"Result for multiplication operation : {multiply}");
    }

    public void Sum(int num1, int num2)
    {
        int sum = num1 + num2;
        Console.WriteLine($"Result for sum operation : {sum}");
    }
}
