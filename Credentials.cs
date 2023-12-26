namespace Uaine.Users
{
    public class Credentials
    {
        public string Password { get; }
        public bool HasPassword { get; }
        public Credentials(string password)
        {
            Password = password;
            HasPassword = !string.IsNullOrEmpty(password); // Set HasPassword based on the presence of a password
        }
    }
}
