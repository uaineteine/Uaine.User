using System.Security.Cryptography;

namespace Uaine.Users
{
    public class HashUser : User
    {
        // public int TruncSize { get; set; }

        public HashUser(User user) : 
            base(Sha(user.Name), "", user.UserGroupID, user.Rank, user.ID)
        {
            ResetPassword(Sha(Credentials.Password));
        }

        public static string Sha(string input)
        {
            // Use input string to calculate MD5 hash
            using (SHA256 sha = SHA256.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = sha.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes); 
            }
        }
    }
}

