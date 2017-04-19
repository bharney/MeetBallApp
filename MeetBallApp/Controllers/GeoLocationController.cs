using System;
using System.Collections.Generic;
using System.Web.Http;
using GeoLocation.Models;
using Newtonsoft.Json;
using System.Linq;


namespace GeoLocation.Controllers
{
    public class GeoLocationController : ApiController
    {
        GeoLocationDb db = new GeoLocationDb();
        //public IEnumerable<Item> Get()
        //{
        //    return new List<Item>
        //    {
        //        new Item { ID = 0
        //        , Address = "1433 N Leavitt"
        //        , City = "Chicago"
        //        , Zip = "60622"
        //        , State = "IL"
        //        , LocationName = "Home"
        //        , Description = "Peen Scene"
        //        , GeoLocationID = "?ID=0"
        //        , GeoLocationName = "Brians Appartment"
        //        , CreateDate = Convert.ToDateTime("4/9/2016")
        //        , EndDate = Convert.ToDateTime("4/28/2016")
        //        , StartDate = Convert.ToDateTime("4/9/2016")
        //        , GPXWKT = "41.907781, -87.681880"
        //        }
        //    };
        //}
        public IHttpActionResult Get()
        {
            try
            {
                //var geoLocation = new List<Item>();
                //var item1 = new Item();
                //item1.ID = 0;
                //item1.Address = "1433 N Leavitt";
                //item1.City = "Chicago";
                //item1.Zip = "60622";
                //item1.State = "IL";
                //item1.LocationName = "Home";
                //item1.Description = "Peen Scene";
                //item1.GeoLocationID = "BrianApt";
                //item1.GeoLocationName = "Brians Appartment";
                //item1.CreateDate = Convert.ToDateTime("4/9/2016");
                //item1.EndDate = Convert.ToDateTime("4/28/2016");
                //item1.StartDate = Convert.ToDateTime("4/9/2016");
                //item1.GPXWKT = "41.907781, -87.681880";
                //var item2 = new Item();
                //item2.ID = 0;
                //item2.Address = "1433 N Leavitt";
                //item2.City = "Chicago";
                //item2.Zip = "60622";
                //item2.State = "IL";
                //item2.LocationName = "Home2";
                //item2.Description = "Peen Scene Obscene";
                //item2.GeoLocationID = "BrianApt2";
                //item2.GeoLocationName = "Brians Appartment2";
                //item2.CreateDate = Convert.ToDateTime("6/9/2016");
                //item2.EndDate = Convert.ToDateTime("7/28/2016");
                //item2.StartDate = Convert.ToDateTime("3/9/2016");
                //item2.GPXWKT = "41.943242, -87.709318";
                //var item3 = new Item();
                //item3.ID = 0;
                //item3.Address = "1433 N Leavitt";
                //item3.City = "Chicago";
                //item3.Zip = "60622";
                //item3.State = "IL";
                //item3.LocationName = "Home";
                //item3.Description = "Elmhurst House";
                //item3.GeoLocationID = "BrianApt3";
                //item3.GeoLocationName = "Brians Appartment3";
                //item3.CreateDate = Convert.ToDateTime("8/9/2016");
                //item3.EndDate = Convert.ToDateTime("9/28/2016");
                //item3.StartDate = Convert.ToDateTime("1/9/2016");
                //item3.GPXWKT = "41.881990, -87.939324";
                //geoLocation.Add(item1);
                //geoLocation.Add(item2);
                //geoLocation.Add(item3);
                var markers = new List<Models.GeoLocation>();

                markers = (from item in db.GeoLocations select item).ToList();

                //foreach (var marker in db.GeoLocations)
                //{
                    
                //}
                //var model = db.GeoLocations;
                
                return Ok(markers);
            }
            catch (Exception)
            {
                return InternalServerError();
                throw;
            }
        }

        //public IHttpActionResult Get (int id)
        //{
        //    try
        //    {
        //        var geoLocation = new List<Item>{
        //                    new Item { ID = 0
        //                    , Address = "1433 N Leavitt"
        //                    , City = "Chicago"
        //                    , Zip = "60622"
        //                    , State = "IL"
        //                    , LocationName = "Home"
        //                    , Description = "Peen Scene"
        //                    , GeoLocationID = "?ID=0"
        //                    , GeoLocationName = "Brians Appartment"
        //                    , CreateDate = Convert.ToDateTime("4/9/2016")
        //                    , EndDate = Convert.ToDateTime("4/28/2016")
        //                    , StartDate = Convert.ToDateTime("4/9/2016")
        //                    , GPXWKT = "41.908866, -87.681975"
        //                    }
        //                };
        //        Item result = geoLocation.Find(x => x.ID == id);

        //        if (result == null)
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            return Ok(result);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return InternalServerError();
        //        throw;
        //    }
        //}
        //[HttpPost]
        //public IHttpActionResult Post([FromBody] Item geoLocation)
        //{
        //    try
        //    {
        //        if (geoLocation == null)
        //        {
        //            return BadRequest();
        //        }

        //        var geoLocationList = new List<Item>();

        //        var existingGeoLocation = new Item
        //        {
        //            ID = 0
        //                    ,
        //            Address = "1433 N Leavitt"
        //                    ,
        //            City = "Chicago"
        //                    ,
        //            Zip = "60622"
        //                    ,
        //            State = "IL"
        //                    ,
        //            LocationName = "Home"
        //                    ,
        //            Description = "Peen Scene"
        //                    ,
        //            GeoLocationID = "?ID=0"
        //                    ,
        //            GeoLocationName = "Brians Appartment"
        //                    ,
        //            CreateDate = Convert.ToDateTime("4/9/2016")
        //                    ,
        //            EndDate = Convert.ToDateTime("4/28/2016")
        //                    ,
        //            StartDate = Convert.ToDateTime("4/9/2016")
        //                    ,
        //            GPXWKT = "41.908866, -87.681975"
        //        };

        //        geoLocationList.Add(existingGeoLocation);       

        //        var createGeoLocation = new Item
        //        {
        //            ID = 1
        //                    ,
        //            Address = "1433 N Leavitt"
        //                    ,
        //            City = "Chicago"
        //                    ,
        //            Zip = "60622"
        //                    ,
        //            State = "IL"
        //                    ,
        //            LocationName = "Home"
        //                    ,
        //            Description = "Peen Scene"
        //                    ,
        //            GeoLocationID = "?ID=1"
        //                    ,
        //            GeoLocationName = "Johns Appartment"
        //                    ,
        //            CreateDate = Convert.ToDateTime("4/9/2016")
        //                    ,
        //            EndDate = Convert.ToDateTime("4/28/2016")
        //                    ,
        //            StartDate = Convert.ToDateTime("4/9/2016")
        //                    ,
        //            GPXWKT = "41.908866, -87.681975"
        //        };

        //        geoLocationList.Add(geoLocation);

        //        return Ok(geoLocationList);

        //    }
        //    catch (Exception)
        //    {
        //        return InternalServerError();
        //        throw;
        //    }
        //}

        //public IHttpActionResult Put(int id, [FromBody] Item geoLocation)
        //{
        //    try
        //    {
        //        if (geoLocation == null)
        //        {
        //            return BadRequest();
        //        }

        //        var geoLocationList = new List<Item>();

        //        var existingGeoLocation = new Item
        //        {
        //            ID = 0
        //                    ,
        //            Address = "1433 N Leavitt"
        //                    ,
        //            City = "Chicago"
        //                    ,
        //            Zip = "60622"
        //                    ,
        //            State = "IL"
        //                    ,
        //            LocationName = "Home"
        //                    ,
        //            Description = "Peen Scene"
        //                    ,
        //            GeoLocationID = "?ID=0"
        //                    ,
        //            GeoLocationName = "Brians Appartment"
        //                    ,
        //            CreateDate = Convert.ToDateTime("4/9/2016")
        //                    ,
        //            EndDate = Convert.ToDateTime("4/28/2016")
        //                    ,
        //            StartDate = Convert.ToDateTime("4/9/2016")
        //                    ,
        //            GPXWKT = "41.908866, -87.681975"
        //        };

        //        var result = geoLocationList.Find(x => x.ID == id);

        //        if (result == null)
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            var updateGeoLocation = new Item
        //            {
        //                ID = id
        //                    ,
        //                Address = geoLocation.Address
        //                    ,
        //                City = geoLocation.City
        //                    ,
        //                Zip = geoLocation.Zip
        //                    ,
        //                State = geoLocation.State
        //                    ,
        //                LocationName = geoLocation.LocationName
        //                    ,
        //                Description = geoLocation.Description
        //                    ,
        //                GeoLocationID = geoLocation.GeoLocationID
        //                    ,
        //                GeoLocationName = geoLocation.GeoLocationName
        //                    ,
        //                CreateDate = geoLocation.CreateDate
        //                    ,
        //                EndDate = geoLocation.EndDate
        //                    ,
        //                StartDate = geoLocation.StartDate
        //                    ,
        //                GPXWKT = geoLocation.GPXWKT
        //            };

        //            return Ok(geoLocation);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return InternalServerError();
        //        throw;
        //    }
        //}

        //public IHttpActionResult Delete(int id)
        //{
        //    try
        //    {
        //        var geoLocationList = new List<Item>();

        //        var existingGeoLocation = new Item
        //        {
        //            ID = 0
        //                    ,
        //            Address = "1433 N Leavitt"
        //                    ,
        //            City = "Chicago"
        //                    ,
        //            Zip = "60622"
        //                    ,
        //            State = "IL"
        //                    ,
        //            LocationName = "Home"
        //                    ,
        //            Description = "Peen Scene"
        //                    ,
        //            GeoLocationID = "?ID=0"
        //                    ,
        //            GeoLocationName = "Brians Appartment"
        //                    ,
        //            CreateDate = Convert.ToDateTime("4/9/2016")
        //                    ,
        //            EndDate = Convert.ToDateTime("4/28/2016")
        //                    ,
        //            StartDate = Convert.ToDateTime("4/9/2016")
        //                    ,
        //            GPXWKT = "41.908866, -87.681975"
        //        };

        //        var result = geoLocationList.Find(x => x.ID == id);

        //        if (result == null)
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            geoLocationList.Remove(result);
        //            return Ok();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return InternalServerError();
        //        throw;
        //    }
        //}

        protected override void Dispose(bool disposing)
        {
            if(db != null)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
