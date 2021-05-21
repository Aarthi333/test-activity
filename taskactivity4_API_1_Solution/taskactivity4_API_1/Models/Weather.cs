using System.ComponentModel.DataAnnotations;
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

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

[assembly: Guid("a9e0c482-ce47-4703-8057-813d0fe6203f")]

namespace taskactivity4_API_1.Models
{
    public class Weather
    {
        [Key]
        public int WeatherID { get; set; }
        public string Date { get; set; }
        public string City { get; set; }
        public float Hightemp { get; set; }
        public float Lowtemp { get; set; }
        public string Forecast { get; set; }

    }
}
