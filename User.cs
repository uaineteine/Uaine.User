using Uaine.Objects.Primitives;
using Uaine.UID;

namespace Uaine.Users
{
    public class User : NamedObject
    {
        public UniqueID ID;
        public Credentials Credentials;
        public User(string name, string password) : base(name)
        {
            ID = new UniqueID(true);
            Credentials = new Credentials(password);
        }
        public User(string name, string password, UniqueID id) : base(name)
        {
            ID = id;
            Credentials = new Credentials(password);
        }

        public void ResetPassword(string newpassword)
        {
            Credentials = new Credentials(newpassword);
        }
    }
}
