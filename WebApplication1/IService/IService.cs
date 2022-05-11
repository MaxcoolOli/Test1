using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using WebApplication1.Service;

namespace WebApplication1.IService
{
    public class Ser: Interface1
    {
        TestDBEntities db = new TestDBEntities();
        private string result;
        public string SaveandPut(string limit, string offset)
        {
            string URL = string.Format("https://opendata.cwb.gov.tw/api/v1/rest/datastore/O-A0001-001?Authorization=CWB-2441446B-9E70-44A3-8426-17B4151F53A0&limit={0}&offset={1}&format=JSON&elementName=&parameterName=", limit, offset);
            try
            {
                Encoding encoding = Encoding.UTF8;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.Method = "GET";
                request.Accept = "text/html, application/json, */*";
                request.ContentType = "application/json";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }

                Weather weather = new Weather();
                weather.JsonData = result;
                weather.CreateTime = DateTime.Now;
                db.Weather.Add(weather);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }
    }
}