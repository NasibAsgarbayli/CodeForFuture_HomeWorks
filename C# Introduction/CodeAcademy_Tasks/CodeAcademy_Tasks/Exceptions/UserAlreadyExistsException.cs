namespace CodeAcademy_Tasks.Exceptions
{
    public class UserAlreadyExistsException : LoginException
    {
        public UserAlreadyExistsException() : base("User is already created")
        {
        }
    }
}
