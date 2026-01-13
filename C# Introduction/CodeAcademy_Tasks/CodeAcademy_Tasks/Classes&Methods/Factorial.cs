using System.Security.Cryptography.X509Certificates;

namespace CodeAcademy_Tasks.Classes_Methods;

public class Factorial
{
    public int number;
    public int Calculate(int Number)
    {
        number = Number;

        if (number < 0)
        {
            throw new ArgumentException("Number must be non-negative.");
        }
        if (number == 0 || number == 1)
        {
            return 1;
        }
        int result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}
