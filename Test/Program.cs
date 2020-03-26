using System;
using System.Linq;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
           
                Address address1 = new Address()
                {
                    Suburb = "Level 3",
                    StreetAddress = "51_Pitt Street",
                    State = "Sydney NSW-2000",
                    Latitude = 1100,
                    Longitude = 2000,
                };
                User newUser = new User()
                {
                    Address = address1,
                    Name = "join",
                    ReferralCode = "ABC123"
                };

                Address address2 = new Address()
                {
                    Suburb = "Level 3",
                    StreetAddress = "51_Pitt Street",
                    State = "Sydney NSW-2000",
                    Latitude = 1100,
                    Longitude = 2000,
                };
                User existingUser = new User()
                {
                    Address = address2,
                    Name = "join 2",
                    ReferralCode = "ABC123"
                };

                bool result = IsMatch(newUser, existingUser);
                
            }

        private static bool IsMatch(User newUser, User existingUser)
        {
            throw new NotImplementedException();
        }
    }
}
