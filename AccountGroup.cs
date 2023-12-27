using System.Text;

namespace Uaine.Users
{
    public class AccountGroup
    {
        List<User> Users { get; }
        List<UserGroup> Groups { get; }

        public AccountGroup()
        {
            Users = new List<User>();
            Groups = new List<UserGroup>();
        }

        public UserGroup GetGroupFromID(GroupID id)
        {
            return Groups.FirstOrDefault(group => group.id == id);
        }

        public void AddUser(User newuser)
        {
            Users.Add(newuser);
        }
        public void AddGroup(UserGroup newgroup)
        {
            Groups.Add(newgroup);
        }

        // Seralize
        public string[] SeraliseUsers()
        {
            string[] output = new string[Users.Count];
            for (int i = 0; i < Users.Count; i++) 
            {
                output[i] = Users[i].SerializeToJson();
            }
            return output;
        }
        public string[] SeraliseGroups()
        {
            string[] output = new string[Groups.Count];
            for (int i = 0; i < Groups.Count; i++)
            {
                output[i] = Groups[i].SerializeToJson();
            }
            return output;
        }

        // De-Seralize
        public static AccountGroup Deserialize(string[] groupsjson, string[] usersjson)
        {
            AccountGroup ag = new AccountGroup();
            foreach(string groupjson in groupsjson)
            {
                UserGroup ug = UserGroup.DeserializeFromJson(groupjson);
                ag.AddGroup(ug);
            }
            foreach(string userjson in usersjson)
            {
                User nu = User.DeserializeFromJson(userjson);
                ag.AddUser(nu);
            }
            return ag;
        }
    }
}
