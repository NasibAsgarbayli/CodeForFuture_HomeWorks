namespace CodeForFuture_Tasks.Extensions;

public static class IntExtension
{
    public static int Pow(this int number, int power)
    {
        int result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }
        return result;
    }
}
