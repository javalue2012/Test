using System;
using System.Text.RegularExpressions;

namespace Test
{
    public class AddressMatcher : IUserMatcher
    {
        public bool IsMatch(User newUser, User existingUser)
        {
            string pattern = "[^0-9a-zA-Z]+";
            string str1 = Regex.Replace(newUser.Address.StreetAddress, pattern, "");
            string str2 = Regex.Replace(existingUser.Address.StreetAddress, pattern, "");
            return str1 == str2;
        }
    }
}
