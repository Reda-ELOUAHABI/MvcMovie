using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET:/helloworld/
        public IActionResult Index()
        {
            return View();
        }
          
        //GET:/helloworld/welcome/
        // public string welcome(string name,int ID = 1)
        public IActionResult welcome(string name, int numtimes = 1)
        {

            //return System.Text.Encodings.Web.HtmlEncoder.Default.Encode($"Salut {name}, Numtimes est : {ID}");
            ViewData["message"] = "Salut" + name;
            ViewData["numTimes"] = numtimes;
            return View();
         
        }
    }
}