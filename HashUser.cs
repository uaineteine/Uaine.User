using Uaine.IO.Checksum;

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
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            Checksum sha = new Checksum(inputBytes);
            return sha.ToString();
        }
    }
}

