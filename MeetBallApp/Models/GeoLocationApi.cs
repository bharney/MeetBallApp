using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace GeoLocation.Models
{
    public partial class GeoLocationDb
    {
        public string EventMarkers { get; set; }
    }
    public class GeoLocationApi
    {
        public static GeoLocationData GetEventData()
        {
            //var baseUrl = "http://wsdev.GeoLocation.com/CodingChallenge/service.svc/json/";
            //var baseUrl = "http://api.chicagoinabox.com/api/geolocation";
            var baseUrl = "http://localhost:29535/api/geolocation";
            //var GeoLocationAPIkey = "Applicant/GeoLocation/F95C1D17-0F24-4003-A7F0-6EC8467336B9";
            //var GeoLocationID = "?GeoLocationID=0";
            //var ID = 0;
            //var GeoLocationApiKey = "F95C1D17-0F24-4003-A7F0-6EC8467336B9";
            WebClient request = new WebClient();
            //var content = syncClient.DownloadString(baseUrl + GeoLocationAPIkey + GeoLocationID);
            //var content = syncClient.DownloadString(baseUrl + GeoLocationID);
            //var content = request.DownloadString(baseUrl + "/" + ID);
            var content = request.DownloadString(baseUrl);
            GeoLocationData itemEventData = new GeoLocationData();
            itemEventData = JsonConvert.DeserializeObject<GeoLocationData>(content);
            //itemEventData = JsonConvert.DeserializeObject<GeoLocationDb>(content);
            return itemEventData;
            //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(GeoLocationData));
            //using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            //{
            //    var eventData = (GeoLocationData)serializer.ReadObject(ms);
            //    return eventData;
            //}

        }

        public static void SendUserData(int GeoLocationID, string firstLastName)
        {

            char[] delimiterChars = { ' ' };
            string[] firstLastNameArray = firstLastName.Split(delimiterChars);
            var firstName = firstLastNameArray[0];
            var lastName = firstLastNameArray[1];
            //var APIKey = "F95C1D17-0F24-4003-A7F0-6EC8467336B9";
        }


    }
}