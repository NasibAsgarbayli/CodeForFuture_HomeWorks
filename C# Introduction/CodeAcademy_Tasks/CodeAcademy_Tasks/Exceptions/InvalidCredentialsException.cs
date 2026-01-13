namespace CodeAcademy_Tasks.Exceptions;

public class InvalidCredentialsException : LoginException
{
    public InvalidCredentialsException() : base("Username or Password is wrong!")
    {
    }
}
