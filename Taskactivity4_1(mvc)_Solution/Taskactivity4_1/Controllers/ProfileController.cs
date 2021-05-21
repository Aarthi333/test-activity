using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Taskactivity4_1.Models;
using Taskactivity4_1.Services;

// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

//[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

//[assembly: Guid("ebd36fa4-bdd7-4f1a-a8e0-dbe789f99eea")]

namespace Taskactivity4_1.Controllers
{
    public class ProfileController : Controller
    {
        private ILogger<ProfileController> _logger;
        private IRepo<Profile> _repo;

        public ProfileController(IRepo<Profile> repo, ILogger<ProfileController> logger)
        {
            _logger = logger;
            _repo = repo;
        }
        public IActionResult Index()
        {
            List<Profile> profiles = _repo.GetAll().ToList();
            return View(profiles);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Profile profile)
        {
            try
            {
                _repo.Add(profile);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Edit(int id)
        {
            Profile profile = _repo.Get(id);
            return View(profile);
        }
        [HttpPost]
        public IActionResult Edit(int id, Profile profile)
        {
            _repo.Update(id, profile);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(Profile profile)
        {
            _repo.Delete(profile);
            return RedirectToAction("Index");
        }


    }
}

