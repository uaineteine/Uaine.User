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
    }
}
