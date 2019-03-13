using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace LDSLibrary.Controllers
{
    public class MoviesController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Watch(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            ViewData["Title"] = "Watch";

            return View();
        }

        public string Edit()
        {
            return "This is the Welcome action method...";
        }

        public string Delete()
        {
            return "This is the Welcome action method...";
        }


    }
}