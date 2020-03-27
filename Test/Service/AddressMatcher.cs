using System;
using System.Text.RegularExpressions;

namespace Test
{
    public class AddressMatcher : IUserMatcher
    {
        public bool IsMatch(User newUser, User existingUser)
        {
            string pattern = "[^0-9a-zA-Z]+";
            string streetAddress1 = Regex.Replace(newUser.Address.StreetAddress, pattern, "");
            string streetAddress2 = Regex.Replace(existingUser.Address.StreetAddress, pattern, "");
            string suburb1 = Regex.Replace(newUser.Address.Suburb, pattern, "");
            string suburb2 = Regex.Replace(existingUser.Address.Suburb, pattern, "");
            string state1 = Regex.Replace(newUser.Address.State, pattern, "");
            string state2 = Regex.Replace(existingUser.Address.State, pattern, "");

            return streetAddress1 == streetAddress2 && suburb1 == suburb2 && state1 == state2;
        }
    }
}
