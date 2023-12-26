using Uaine.Objects.Primitives.ID;

namespace Uaine.Users
{
    public class GroupID : PolyID32
    {
        public GroupID(ID32[] IDArray) : base(IDArray)
        {
        }
        public GroupID(ID16[] IDArray) : base(IDArray)
        {
        }
    }
}
