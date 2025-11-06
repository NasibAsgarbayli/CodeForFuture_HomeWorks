namespace CodeForFuture_Tasks.Models;

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Greeting()
    {
        Console.WriteLine("Salam! Mən " + Name + "am.");
    }
}
