using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.HttpResponseSerialize.Models
{
    public class User
    {
        [JsonIgnore()]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public Company Company { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        [JsonProperty("zipcode")]
        public string Zip { get; set; }
        [JsonProperty("geo")]
        public GeoLocation GeoLocation { get; set; }
    }

    public class GeoLocation
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }

    public class Company
    {
        public string Name { get; set; }
        public string CatchPhrase { get; set; }
        public string Bs { get; set; }
    }
}
