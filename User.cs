using Uaine.Objects.Primitives;
using Uaine.UID;

namespace Uaine.Users
{
    public class User : NamedObject
    {
        public UniqueID ID;
        public Credentials Credentials;
        public UserGroup Group;
        public int Rank { get; }
        public User(string name, string password, UserGroup group) : base(name)
        {
            ID = new UniqueID(true);
            Credentials = new Credentials(password);
            Group = group;
            Rank = UserRank.OrdinaryUser;
        }
        public User(string name, string password, UserGroup group, int userank) : base(name)
        {
            ID = new UniqueID(true);
            Credentials = new Credentials(password);
            Group = group;
            Rank = userank;
        }
        public User(string name, string password, UserGroup group, UniqueID id) : base(name)
        {
            ID = id;
            Credentials = new Credentials(password);
            Group = group;
            Rank = UserRank.OrdinaryUser;
        }
        public User(string name, string password, UserGroup group, int userank, UniqueID id) : base(name)
        {
            ID = id;
            Credentials = new Credentials(password);
            Group = group;
            Rank = userank;
        }

        public void ResetPassword(string newpassword)
        {
            Credentials = new Credentials(newpassword);
        }
    }
}
