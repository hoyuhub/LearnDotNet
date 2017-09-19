using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LearnDoNet.Models;
using System.IO;
using Newtonsoft.Json;
using Learn.LearnDbContext;

namespace LearnDoNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult EasyData()
        {
            GetList();
            FileStream file = new FileStream("e:/test.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(file);
            List<double> list = new List<double>();
            while (!streamReader.EndOfStream)
            {
                string strLine = streamReader.ReadLine();
                string[] strArray = strLine.Split(' ');
                if (strArray.Length == 3)
                    list.Add(Convert.ToDouble(strArray[2]));
            }
            file.Close();
            streamReader.Close();

            return Json(list);
        }

        public void GetList()
        {
            using (var context = new LearnDbContext())
            {
                var blogs = context.Spending.ToList();
            }

        }
    }
}
