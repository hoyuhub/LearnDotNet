using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnDotNet.Controllers
{
    public class DataController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        
    }
}