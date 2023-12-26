namespace Uaine.Users
{
    public class Permissions
    {
        private readonly List<string> allowedActions;

        public Permissions(string[] actions)
        {
            allowedActions = new List<string>(actions);
        }

        public bool CanPerformAction(string action)
        {
            return allowedActions.Contains(action);
        }

        public void AddPermission(string action)
        {
            if (!allowedActions.Contains(action))
            {
                allowedActions.Add(action);
            }
            else
            {
                throw new InvalidOperationException("Permission already exists.");
                // Alternatively, you can handle this case differently based on your application's needs
            }
        }

        public void RemovePermission(string action)
        {
            if (allowedActions.Contains(action))
            {
                allowedActions.Remove(action);
            }
            else
            {
                throw new InvalidOperationException("Permission does not exist.");
                // Alternatively, you can handle this case differently based on your application's needs
            }
        }
    }
}
