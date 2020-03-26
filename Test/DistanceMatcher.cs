using System;
namespace Test
{
    public class DistanceMatcher : IUserMatcher
    {
        public class Location
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
        }
        private static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }
        public bool IsMatch(User newUser, User existingUser)
        {
            Location location1 = new Location();
            Location location2 = new Location();
            location1.latitude = newUser.Address.Latitude;
            location1.longitude = newUser.Address.Latitude;
            location2.latitude = existingUser.Address.Latitude;
            location2.longitude = existingUser.Address.Longitude;
            double radius = 500.0;
            try
            {
                if (CalculateDistance(location1, location2) < radius)
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
        public static double CalculateDistance(Location location1, Location location2)
        {
            double circumference = 40000.0; // Earth's circumference at the equator in km
            double distance = 0.0;
            //Calculate radians
            double latitude1Rad = DegreesToRadians(location1.latitude);
            double longitude1Rad = DegreesToRadians(location1.longitude);
            double latititude2Rad = DegreesToRadians(location2.latitude);
            double longitude2Rad = DegreesToRadians(location2.longitude);
            double logitudeDiff = Math.Abs(longitude1Rad - longitude2Rad);
            if (logitudeDiff > Math.PI)
            {
                logitudeDiff = 2.0 * Math.PI - logitudeDiff;
            }
            double angleCalculation =
                Math.Acos(
                  Math.Sin(latititude2Rad) * Math.Sin(latitude1Rad) +
                  Math.Cos(latititude2Rad) * Math.Cos(latitude1Rad) * Math.Cos(logitudeDiff));
            distance = circumference * angleCalculation / (2.0 * Math.PI);
            return (distance * 1000);
        }
    }
   
  }
