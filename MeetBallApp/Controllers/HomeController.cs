using GeoLocation.Models;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace GeoLocation.Controllers
{
    public class HomeController : Controller
    {
        //private GeoLocationDb eventInfo = new GeoLocationDb();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var eventInfo = new GeoLocationData();
            //Take the serialized Json object and assign to event info object.
            eventInfo = GeoLocationApi.GetEventData();

            eventInfo.CurrGeoLocation = eventInfo.GeoLocationDataObj.GeoLocations.First();
            //Get the Event Coordinates. Need to Parse out the POINT ( and additional coordinates.
            //GPXWKT = "41.907781, -87.681880"
            //var GPXWKT = (eventInfo.Item.GPXWKT).Substring(6, (eventInfo.Item.GPXWKT).Length - 6);
            //char[] delimiterChars = { ' ', '(' };
            char[] delimiterChars = { ',' };
            //Assign Long/Lat for access in view.
            List<string> markers = new List<string>();
            
            foreach (var item in eventInfo.GeoLocationDataObj.GeoLocations)
            {
                string[] coordinates = item.GPXWKT.Split(delimiterChars);
                string eventMarker = "['" + item.Name + "', " + coordinates[0].Trim() + ", " + coordinates[1].Trim() + "]";
  
                markers.Add(eventMarker);
            }
            eventInfo.EventMarkers = string.Join(",", markers);

            return View(eventInfo);
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult JoinEvent(Models.GeoLocation model)
        {
            //model..GeoLocationID = model.ID;

            return View();
        }
    }
}