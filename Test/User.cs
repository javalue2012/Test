using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    public class User
    {
    public Address Address { get; set; }
    public string Name { get; set; }
    public string ReferralCode { get; set; }
    public List<User> listuser { get; set;  }
    }
}
