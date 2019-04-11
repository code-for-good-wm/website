using System;

namespace CodeForGood.Components
{
    public class WeekendForGoodServices
    {
        public static DateRange WhenIsWeekendForGood()
        {
			const string startDate = "November 1, 2019";
            const string endDate = "November 3, 2019";

            var gmtOffset = TimeSpan.FromHours(-5);

            return new DateRange
            {
                From = new DateTimeOffset(DateTime.Parse(startDate), gmtOffset),
                To = new DateTimeOffset(DateTime.Parse(endDate), gmtOffset)
            };
        }

	    public static DateRange WhenIsLeadForGood()
	    {
		    const string startDate = "May 2, 2018 6:00pm";
		    const string endDate = "May 2, 2018 8:00pm";

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
                Country = "United States of America",
                Planet = "Earth"
            };
        }
    }
}