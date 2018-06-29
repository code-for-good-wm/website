using System;

namespace CodeForGood.Components
{
    public class WeekendForGoodServices
    {
        public static DateRange WhenIsWeekendForGood()
        {

            var startDate = "November 2, 2018";
            var endDate = "November 4, 2018";

            var gmtOffset = TimeSpan.FromHours(-5);

            return new DateRange
            {
                From = new DateTimeOffset(DateTime.Parse(startDate), gmtOffset),
                To = new DateTimeOffset(DateTime.Parse(endDate), gmtOffset)
            };
        }

        public static LocationAddress WhereIsWeekendForGood()
        {
            return new LocationAddress
            {
                Name = "Start Garden",
                AddressLine1 = "40 Pearl St NW #200",
                City = "Grand Rapids",
                State = "MI",
                PostalCode = "49503",
                Country = "US",
                Planet = "Earth"
            };
        }
    }
}