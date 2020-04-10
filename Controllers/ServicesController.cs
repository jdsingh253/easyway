using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using customLogin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace customLogin.Controllers
{
   
    public class ServicesController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        public ServicesController(IHostingEnvironment hostingEnvironment)
        {

        }
        public IActionResult IELTS_Demo()
        {
            return View();
        }
        [HttpGet]
        public IActionResult IELTS_Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult IELTS_Create(IELTSVideos model)
        {
            string uniqueFileName = null;
            if(model.Videos !=null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "ielts_videos");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Videos.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                model.Videos.CopyTo(new FileStream(filePath, FileMode.Create));
            }
            IELTSVideos newVideo = new IELTSVideos
            {
                Name = model.Name,
                VideoPath = uniqueFileName
            };
            return View();
        }
        public IActionResult DrivingSchool_Index()
        {
            return View();
        }
        public IActionResult CLicenceDemo()
        {
            return View();
        }
        public IActionResult CQCLicenceDemo()
        {
            return View();
        }
        public IActionResult BLicenceDemo()
        {
            return View();
        }
        public IActionResult DrivingSchool()
        {
            return View();
        }
    }
}