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
                int dem = 0;
                for (int i = 0; i < newUser.ReferralCode.Count(); i++)
                {
                    
                    for(int j = 0; j< existingUser.ReferralCode.Count(); j++)
                    {
                        if(newUser.ReferralCode[i] == existingUser.ReferralCode[j])
                        {
                            dem++;
                        }
                    }
                }
                if (dem == 3)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
