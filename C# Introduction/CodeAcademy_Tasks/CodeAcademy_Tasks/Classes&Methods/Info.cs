namespace CodeAcademy_Tasks.Classes_Methods;

public class Info
{
    public string mail;
    public string password;

    public bool InfoCheck (string Mail,string Password)
    {
        mail = Mail;
        password = Password;

        if (mail == "emil@code.edu.az" && password == "12345")
        {
            Console.WriteLine("Successfully logged in.");
            return true;
        }
        Console.WriteLine("Mail or password is wrong");
        return false;
    }
}
