using System;
namespace Test
{
    public class DistanceMatcher : IUserMatcher
    {
        public bool IsMatch(User newUser, User existingUser)
        {
            double distance = CalculateDistance(newUser.Address.Latitude, newUser.Address.Longitude, existingUser.Address.Latitude, existingUser.Address.Longitude));
            return distance < 500;
        }
        static double CalculateDistance(decimal lat1, decimal lon1, decimal lat2, decimal lon2)
        {
            double R = 6371; // km
            double distance = 0.0;

            double dLat = (double)(lat2 - lat1) * Math.PI / 180;
            double dLon = (double)(lon2 - lon1) * Math.PI / 180;
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
              Math.Cos((double)lat1 * Math.PI / 180) * Math.Cos((double)lat2 * Math.PI / 180) *
              Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            distance = R * c;
            return (distance * 1000); //metres
        }
    }
  }
