using System.Collections.Generic;

namespace Katas
{
    public static class FriendOrFoeKata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            IList<string> friends = new List<string>();

            foreach (var name in names)
            {
                if (name.Length == 4)
                {
                    friends.Add(name);
                }
            }

            return friends;
        }
    }
}
