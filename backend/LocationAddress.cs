using System;

using Microsoft.AspNetCore.Http;

namespace CodeForGood
{
    public class LocationAddress
    {
        public string Name { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Planet { get; set; }

	    public string GoogleMapsLink()
	    {
		    var queryArgs = new QueryString()
			    .Add("daddr",
				    $"{Name}, {AddressLine1}, {City}, {State} {PostalCode}");

		    var directionsUrl = new UriBuilder("https://maps.google.com/")
		    {
			    Query = queryArgs.ToString()
		    };

		    return directionsUrl.ToString();
	    }
    }
}