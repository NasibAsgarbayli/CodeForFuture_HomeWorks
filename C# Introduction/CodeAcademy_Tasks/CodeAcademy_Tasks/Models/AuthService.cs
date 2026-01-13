using CodeAcademy_Tasks.Exceptions;

namespace CodeAcademy_Tasks.Models;

public class AuthService
{
    private List<User> _users;
    public AuthService()
    {
        _users = new List<User>();
    }
    public void Register(string username, string password)
    {
        foreach (var item in _users)
        {
            try
            {
                if (item.Username == username)
                {
                    throw new UserAlreadyExistsException();
                }
            }
            catch (UserAlreadyExistsException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
        User newUser = new()
        {
            Username = username,
            Password = password
        };
        _users.Add(newUser);
        Console.WriteLine("User registered successfully");
    }

    public void Login(string username, string password)
    {
        var user = _users.Find(u => u.Username == username);
        try
        {
            if (user == null || user.Password != password)
            {
                throw new InvalidCredentialsException();
            }
        }
        catch (InvalidCredentialsException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        Console.WriteLine($"Welcome, {username}!");
    }
}
