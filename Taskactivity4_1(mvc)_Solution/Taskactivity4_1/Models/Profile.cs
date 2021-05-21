using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

[assembly: Guid("c283218a-1228-475d-ad72-2345f0835908")]

namespace Taskactivity4_1.Models
{
    public class Profile
    {
        [Key]
        public int Profile_Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Qualification { get; set; }
        public string IsEmployed { get; set; }
        public string NoticePeriod { get; set; }
        public float CurrentCTC { get; set; }
    }
}
