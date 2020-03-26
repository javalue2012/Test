using System;
using System.Text.RegularExpressions;

namespace Test
{
    public class AddressMatcher : IUserMatcher
    {
        public bool IsMatch(User newUser, User existingUser)
        {
            string removableChars = Regex.Escape(@"@&'()<>#");
            string pattern = "[" + removableChars + "]";
            string str1 = Regex.Replace(newUser.Address.StreetAddress, pattern, "");
            string str2 = Regex.Replace(existingUser.Address.StreetAddress, pattern, "");

            return str1 == str2 && newUser.Name == existingUser.Name;
        }
    }
}
