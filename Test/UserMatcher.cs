using System;
using System.Linq;
using static Test.User;

namespace Test
{
    public interface IUserMatcher
    {
        bool IsMatch(User newUser, User existingUser);
    }

    public class DistanceMatcher : IUserMatcher
    {
        
        public bool IsMatch(User newUser, User existingUser)
        {
            decimal a = newUser.Address.Latitude + newUser.Address.Longitude;
            decimal b = existingUser.Address.Longitude + existingUser.Address.Longitude;
            try
            {
                if (a != b)
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
    public class AddressMatcher : IUserMatcher
    {

        public bool IsMatch(User newUser, User existingUser)
        {
           try
            {
                if (existingUser.Address != newUser.Address)
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
