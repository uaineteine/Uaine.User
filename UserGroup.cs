using Newtonsoft.Json;
using Uaine.Objects.Primitives;
using Uaine.Objects.Primitives.ID;

namespace Uaine.Users
{
    public class UserGroup : NamedObject
    {
        public GroupID id;
        public Permissions Permissions;

        public UserGroup(string groupName, PolyID32 id, Permissions permissions) : base(groupName)
        {
            this.id = (GroupID)id;
            Permissions = permissions;
        }

        // Serialize method to convert UserGroup to a JSON string
        public string SerializeToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        // Deserialize method to create a UserGroup from a JSON string
        public static UserGroup DeserializeFromJson(string json)
        {
            return JsonConvert.DeserializeObject<UserGroup>(json);
        }
    }
}
