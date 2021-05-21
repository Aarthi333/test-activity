using System.Runtime.InteropServices;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

//[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

//[assembly: Guid("23c2aa16-bc3c-4a06-83a7-a4e002cb7db9")]


namespace taskactivity4_Client.Models
{
    public class Weather
    {
       
        public int WeatherID { get; set; }
        public string Date { get; set; }
        public string City { get; set; }
        public float Hightemp { get; set; }
        public float Lowtemp { get; set; }
        public string Forecast { get; set; }

    }
}
