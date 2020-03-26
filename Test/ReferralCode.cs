using System;
using System.Linq;
using static Test.User;

namespace Test
{
       public class ReferralCode : IUserMatcher
    {

        public bool IsMatch(User newUser, User existingUser)
        {

            try
            {
                if (existingUser.Name != newUser.Name)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
