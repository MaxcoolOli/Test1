using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Model
    {
        //public string success { get; set; }
        //[JsonProperty("result")]
        //public List<string> result { get; set; }
        //[JsonProperty("records")]

        //public List<string> records { get; set; }

        public class Field
        {
            public string id { get; set; }
            public string type { get; set; }
        }

        public class Location
        {
            public string lat { get; set; }
            public string lon { get; set; }
            public string locationName { get; set; }
            public string stationId { get; set; }
            public Time time { get; set; }
            public List<WeatherElement> weatherElement { get; set; }
            public List<Parameter> parameter { get; set; }
        }

        public class Parameter
        {
            public string parameterName { get; set; }
            public string parameterValue { get; set; }
        }

        public class Records
        {
            public List<Location> location { get; set; }
        }

        public class Result
        {
            public string resource_id { get; set; }
            public List<Field> fields { get; set; }
        }

        public class Root
        {
            public string success { get; set; }
            public Result result { get; set; }
            public Records records { get; set; }
        }

        public class Time
        {
            public string obsTime { get; set; }
        }

        public class WeatherElement
        {
            public string elementName { get; set; }
            public string elementValue { get; set; }
        }

    }
}