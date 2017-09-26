using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace LearnDotNet.Controllers
{
    public class DataController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        
        public void Upload()
        {
            var file=Request.Form.Files;        
        }
    }
}