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
        public string[] generateCode(string code)
        {
            string[] arrCode = new string[] { code };
            string[] arrayCodes = new string[code.Length - 1];
            arrayCodes[0] = code;

            for (int i = 1; i < code.Length - 1; i++)
            {
                string newCode = "";
                for (int j = 0; j < code.Length; j++)
                {
                    if (i == j + 1)
                    {
                        newCode = newCode + code[i + 1];
                    }
                    else if (i == j - 1)
                    {
                        newCode = newCode + code[i - 1];
                    }
                    else newCode = newCode + code[j];
                }
                arrayCodes[i] = newCode;
            }

            return arrayCodes;
        }

        public bool compareCode(string code1, string code2)
        {
            string[] arrayCodes = generateCode(code1);

            for (int i = 0; i < arrayCodes.Length; i++)
            {
                if (arrayCodes[i] == code2)

                    return true;
            }

            return false;
        }
    }
}
