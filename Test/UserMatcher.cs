using System;
using System.Linq;
using static Test.User;

namespace Test
{
    public interface IUserMatcher
    {
        bool IsMatch(User newUser, User existingUser);

    }
    

}
