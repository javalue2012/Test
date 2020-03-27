using System;
using System.Linq;
using static Test.User;

namespace Test
{
       public class ReferralMatcher : IUserMatcher
    {
        public bool IsMatch(User newUser, User existingUser)
        {
            return compareCode(newUser.ReferralCode, existingUser.ReferralCode);
        }

        public string[] generateCode(string newReferralCode)
        {
            string[] arrCode = new string[] { newReferralCode };
            string[] arrayCodes = new string[newReferralCode.Length - 1];
            arrayCodes[0] = newReferralCode;

            for (int i = 1; i < newReferralCode.Length - 1; i++)
            {
                string newCode = "";
                for (int j = 0; j < newReferralCode.Length; j++)
                {
                    if (i == j + 1)
                    {
                        newCode = newCode + newReferralCode[i + 1];
                    }
                    else if (i == j - 1)
                    {
                        newCode = newCode + newReferralCode[i - 1];
                    }
                    else newCode = newCode + newReferralCode[j];
                }
                arrayCodes[i] = newCode;
            }

            return arrayCodes;
        }

        public bool compareCode(string newReferralCode, string existingReferralCode)
        {
            if(newReferralCode.Length != existingReferralCode.Length)
            {
                return false;
            }
            else
            {
                string[] arrayCodes = generateCode(newReferralCode);

                for (int i = 0; i < arrayCodes.Length; i++)
                {
                    if (arrayCodes[i] == existingReferralCode)

                        return true;
                }
            }
            
            return false;
        }
    }
}
