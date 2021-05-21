using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
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

[assembly: Guid("228b25e7-82c5-42d0-9bca-6cd38312e07f")]

namespace taskactivity4_Client.Models
{
    public class City
    {
        
        public int City_ID { get; set; }
        public string Forecast { get; set; }
        public string Pincode { get; set; }

    }
}
