using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Taskactivity4_1.Models;

// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

//[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

//[assembly: Guid("cfc88760-2b76-46a1-a872-ff4c4515b1b6")]

namespace Taskactivity4_1.Models
{
    public class ProfileContext : DbContext
    {
        public ProfileContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Profile> Profiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>().HasData(
                new Profile() { Profile_Id=1 ,Name = "Ramu",Age=30,Qualification="BSC" ,IsEmployed="YES",NoticePeriod="2",CurrentCTC=30000});
        }
    }
}
