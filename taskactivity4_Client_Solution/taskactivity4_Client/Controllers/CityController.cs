using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using taskactivity4_Client.Models;

// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

//[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

//[assembly: Guid("461d0323-ccdc-4531-a62c-b0cd5d183011")]

namespace taskactivity4_Client.Controllers
{
    public class CityController : Controller
    {
        public async Task<ActionResult> Index()
        {
            string Baseurl = "http://localhost:19912/";  //http://localhost:19912/api/Cities
            var ProdInfo = new List<City>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/Cities");
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var ProdResponse = Res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list  
                    ProdInfo = JsonConvert.DeserializeObject<List<City>>(ProdResponse);
                }
                //returning the employee list to view  
                return View(ProdInfo);
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(City sbt)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(sbt), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("http://localhost:19912/api/Cities", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<City>(apiResponse);
                }
            }
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> Edit(int id)
        {
            TempData["City_ID"] = id;
            City b = new City();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:19912/api/Cities/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    b = JsonConvert.DeserializeObject<City>(apiResponse);
                }
            }
            return View(b);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(City b)
        {
            int vid = Convert.ToInt32(TempData["City_ID"]);
            b.City_ID = vid;
            City receivedemp = new City();
            using (var httpClient = new HttpClient())
            {
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(b), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("http://localhost:19912/api/Cities/" + vid, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    receivedemp = JsonConvert.DeserializeObject<City>(apiResponse);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Weather")]
        public async Task<List<Weather>> GetWeather()
        {
            string Baseurl = "http://localhost:19912/";
            var ProdInfo = new List<Weather>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/Cities/Weather");
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var ProdResponse = Res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response recieved from web api and storing into the Employee list  
                    ProdInfo = JsonConvert.DeserializeObject<List<Weather>>(ProdResponse);
                }
                //returning the employee list to view  
                return ProdInfo;
            }
        }

        [HttpGet]
        [Route("WeatherforCity")]
        public async Task<Weather> GetWeatherForACity()
        {
            Weather sba = new Weather();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:19912/api/Cities/WeatherforCity?id=1"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    sba = JsonConvert.DeserializeObject<Weather>(apiResponse);
                }
            }
            return sba;
        }
    }
}
