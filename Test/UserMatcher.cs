using System;
using System.Linq;
using static Test.User;

namespace Test
{
    public class UserMatcher : IUserMatcher
    {
    public bool IsMatch(User newUser, User existingUser)
        {
            AddressMatcher addressMatcher = new AddressMatcher();
            DistanceMatcher distanceMatcher = new DistanceMatcher();
            ReferralMatcher referralMatcher = new ReferralMatcher();

            if (addressMatcher.IsMatch(newUser, existingUser)) return true;
            
            if (distanceMatcher.IsMatch(newUser, existingUser)) return true;

            return referralMatcher.IsMatch(newUser, existingUser);

        }
    }
}
