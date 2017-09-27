using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace LearnDotNet.Controllers
{
    public class DataController : Controller
    {

        public ActionResult Create()
        {
            return View();
        }


        //上传文件，将文件放在指定文件夹下，计划做成工具类
        // public async Task<IActionResult> Upload(List<IFormFile> files)
        // {
        //     long size = files.Sum(f => f.Length);
        //     var filePath = Path.GetTempFileName();

        //     foreach (var formFile in files)
        //     {
        //         if (formFile.Length > 0)
        //         {
        //             using (var stream = new FileStream(filePath, FileMode.Create))
        //             {
        //                 await formFile.CopyToAsync(stream);
        //             }
        //         }
        //     }
        //     return Ok(new { count = files.Count, size, filePath });
        // }

        public string Upload()
        {
            var files = Request.Form.Files;

            return "finish";
        }

    }
}