namespace CodeAcademy_Tasks.Models;

public  class SimpleGenericType<T>
{
    public T RandomValue { get; set; }
    public SimpleGenericType(T randommValue)
    {
        RandomValue = randommValue;
    }

    public void Print(T value)
    {
        Console.WriteLine();
    }
}
