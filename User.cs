using Newtonsoft.Json;
using Uaine.Objects.Primitives;
using Uaine.Objects.Primitives.ID;
using Uaine.UID;

namespace Uaine.Users
{
    public class User : NamedObject
    {
        public UniqueID ID;
        public Credentials Credentials;
        public GroupID UserGroupID { get; private set; }
        public int Rank { get; private set; }
        public User(string name, string password, PolyID32 group) : base(name)
        {
            ID = new UniqueID(true);
            Credentials = new Credentials(password);
            UserGroupID = (GroupID)group;
            Rank = UserRank.OrdinaryUser;
        }
        public User(string name, string password, PolyID32 group, int userank) : base(name)
        {
            ID = new UniqueID(true);
            Credentials = new Credentials(password);
            UserGroupID = (GroupID)group;
            Rank = userank;
        }
        public User(string name, string password, PolyID32 group, UniqueID id) : base(name)
        {
            ID = id;
            Credentials = new Credentials(password);
            UserGroupID = (GroupID)group;
            Rank = UserRank.OrdinaryUser;
        }
        public User(string name, string password, PolyID32 group, int userank, UniqueID id) : base(name)
        {
            ID = id;
            Credentials = new Credentials(password);
            UserGroupID = (GroupID)group;
            Rank = userank;
        }

        public void ResetPassword(string newpassword)
        {
            Credentials = new Credentials(newpassword);
        }

        public void ReassignGroup(PolyID32 newUserGroup)
        {
            UserGroupID = (GroupID)(newUserGroup);
        }

        public void SetUserRank(int newRank)
        {
            Rank = newRank;
        }

        // Serialize method to convert UserGroup to a JSON string
        public string SerializeToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        // Deserialize method to create a UserGroup from a JSON string
        public static User DeserializeFromJson(string json)
        {
            return JsonConvert.DeserializeObject<User>(json);
        }
    }
}
