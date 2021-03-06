using NUnit.Framework;
using Test;

namespace Tests
{
    public class DistanceMatcherTest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void IsMatch_MatchDistance_ReturnTrue()
        {
            var distanceMatcher = new UserMatcher();
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
                Name = "Luong",
                ReferralCode = "ABC123"
            };

            Address address2 = new Address()
            {
                Suburb = "Level 3",
                StreetAddress = "51_Pitt Street",
                State = "Sydney NSW-2000",
                Latitude = 110,
                Longitude = 200,
            };
            User existingUser = new User()
            {
                Address = address2,
                Name = "Luong 2",
                ReferralCode = "ABC123"
            };

            var isMatch = distanceMatcher.IsMatch(newUser, existingUser);

            Assert.True(isMatch);
        }
       
         
    }
}