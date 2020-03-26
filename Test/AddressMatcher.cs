using System;
using System.Linq;
using System.Text.RegularExpressions;
using static Test.User;

namespace Test
{
    public class AddressMatcher : IUserMatcher
    {
        public class Compareaddress
        {
            public string StreetAddress { get; set; }
            public string name { get; set; }
        }
        public bool IsMatch(User newUser, User existingUser)
        {
            Compareaddress location1 = new Compareaddress();
            Compareaddress location2 = new Compareaddress();
            location1.StreetAddress = newUser.Address.StreetAddress;
            location1.name = newUser.Name;
            location2.StreetAddress = existingUser.Address.StreetAddress;
            location2.name = existingUser.Name;
            try
            {
                if (Compare(location1, location2) == true)
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
        public static bool Compare(Compareaddress location1, Compareaddress location2)
        {
            string pattern = "@!^.*$";
            string str1 = Regex.Replace(location1.StreetAddress, pattern, " ");
            string str2 = Regex.Replace(location2.StreetAddress, pattern, " ");
            if(str1 == str2 && location1.name == location2.name)
            {
                return false;
            }
          
            return true;
        }
    }
 }
