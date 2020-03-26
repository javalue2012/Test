using NUnit.Framework;
using Test;

namespace Tests
{
    public class AddressMatcherTest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void IsMatch_MatchName_ReturnTrue()
        {
            var addressMatcher = new AddressMatcher();
            var currentUser = new User
            {
                Address = new Address
                {
                    Latitude = 123.2m,
                    Longitude = 12.3m,
                    State = "aaa",
                    StreetAddress = "111",
                    Suburb = "222"
                },
                Name = "Luong",
                ReferralCode = "ABC123"
            };

            var newUser = new User
            {
                Address = new Address
                {
                    Latitude = 13.2m,
                    Longitude = 112.3m,
                    State = "aaaa",
                    StreetAddress = "111aa",
                    Suburb = "222"
                },
                Name = "Luong",
                ReferralCode = "ABC1231"
            };

            var isMatch = addressMatcher.IsMatch(newUser, currentUser);

            Assert.True(isMatch);
        }
    }
}