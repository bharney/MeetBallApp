
using System.Collections.Generic;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace GeoLocation.Models
{
    [JsonObject(memberSerialization: MemberSerialization.OptIn)]
    public partial class GeoLocationDb
    {
        [JsonProperty("ID")]
        public int ID { get { return this.ID; } set { this.ID = value; } }
        [JsonProperty("Address")]
        public string Address { get { return this.Address; } set { this.Address = value; } }
        [JsonProperty("City")]
        public string City { get { return this.City; } set { this.City = value; } }
        [JsonProperty("State")]
        public string State { get { return this.State; } set { this.State = value; } }
        [JsonProperty("Zip")]
        public string Zip { get { return this.Zip; } set { this.Zip = value; } }
        [JsonProperty("GPXWKT")]
        public string GPXWKT { get { return this.GPXWKT; } set { this.GPXWKT = value; } }
        [JsonProperty("CreateDate")]
        public Nullable<System.DateTime> CreateDate { get { return this.CreateDate; } set { this.CreateDate = value; } }
        [JsonProperty("Description")]
        public string Description { get { return this.Description; } set { this.Description = value; } }
        [JsonProperty("StartDate")]
        public Nullable<System.DateTime> StartDate { get { return this.StartDate; } set { this.StartDate = value; } }
        [JsonProperty("EndDate")]
        public Nullable<System.DateTime> EndDate { get { return this.EndDate; } set { this.EndDate = value; } }
        [JsonProperty("Name")]
        public string Name { get { return this.Name; } set { this.Name = value; } }
        [JsonProperty("GeoLocationEvent")]
        public string GeoLocationEvent { get { return this.GeoLocationEvent; } set { this.GeoLocationEvent = value; } }
    }

    public class GeoLocationData
    {
        public List<GeoLocation> GeoLocations { get; set; }

        public GeoLocation CurrGeoLocation { get; set; }

        public string EventMarkers { get; set; }

        public int Longitude { get; set; }

        public int Latitude { get; set; }

        public GeoLocationDb GeoLocationDataObj  { get; set; }

    }
}

////    public class LocationResult
////    {
////        public string DeveloperErrorMsg { get; set; }
////        public int ErrorType { get; set; }
////        public string FriendlyErrorMsg { get; set; }
////        public bool Success { get; set; }
////    }

////    public class JoinLocation
////    {
////        public string GeoLocationID { get; set; }
////        public string FirstName { get; set; }
////        public string LastName { get; set; }
////        public string FullName { get; set; }
////        public string PhoneNumber { get; set; }
////        public string EmailAddress { get; set; }
////        public string APIKey { get; set; }
////    }
////}