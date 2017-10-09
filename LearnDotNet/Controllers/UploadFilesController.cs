using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System;
using LearnDotNet.Model;
using LearnDotNet.Dal;

namespace LearnDotNet.Controllers
{
    public class UploadFilesController : Controller
    {
        private readonly IHostingEnvironment host;
        public ActionResult Create()
        {
            return View();
        }

        public UploadFilesController(IHostingEnvironment host)
        {
            this.host = host;
        }

        //上传文件，将文件放在指定文件夹下，计划做成工具类   
        //
        //此方法虽然和官网提供的一样，但是files始终接收不到数据
        //[HttpPost]
        //public async Task<IActionResult> Upload(List<IFormFile> files)
        //{
        //    long size = files.Sum(f => f.Length);
        //    var filePath = Path.GetTempFileName();
        //    //var file = Request.Form.Files;
        //    foreach (var formFile in files)
        //    {
        //        if (formFile.Length > 0)
        //        {
        //            using (var stream = new FileStream(filePath, FileMode.Create))
        //            {
        //                await formFile.CopyToAsync(stream);
        //            }
        //        }
        //    }
        //    return Ok(new { count = files.Count, size, filePath });
        //}



        public void Upload()
        {
            var files = Request.Form.Files;
            long size = files.Sum(f => f.Length);
            List<string> listFileName = new List<string>();
            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                    string name = DateTime.Now.ToString("yyyyMMddhhmmss") + file.FileName;
                    using (FileStream fs = new FileStream(Path.Combine(host.WebRootPath, name), FileMode.CreateNew))
                    {
                        file.CopyTo(fs);
                        listFileName.Add(name);
                        fs.Flush();
                    }

                }
            }
            CreateData(listFileName);

        }




        public bool CreateData(List<string> listFileName)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < listFileName.Count; i++)
            {
                string path = host.WebRootPath + "\\" + listFileName[0];
                StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
                string line = sr.ReadLine();
                while (line != null)
                {
                    list.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }



            for (int i = 0; i < list.Count; i++)
            {
                string[] strArray = list[i].Trim().Split(" ");
                Spending sp = new Spending();
                sp.date = Convert.ToDateTime(("2017." + strArray[0]));
                sp.sys_date = DateTime.Now;
                sp.amount = Convert.ToDecimal(strArray[2]);
                sp.reason = strArray[1];
                SpendingDal dalSpending = new SpendingDal();
                dalSpending.Add(sp);
            }

            return false;
        }

    }
}