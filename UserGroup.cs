using Uaine.Objects.Primitives;
using Uaine.Objects.Primitives.ID;

namespace Uaine.Users
{
    public class UserGroup : NamedObject
    {
        public PolyID32 id;
        public Permissions Permissions;

        public UserGroup(string groupName, PolyID32 id, Permissions permissions) : base(groupName)
        {
            this.id = id;
            Permissions = permissions;
        }
    }
}
