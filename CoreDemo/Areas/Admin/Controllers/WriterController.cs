﻿using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }

        public IActionResult GetWriterByID(int writerid)
        {
            var findwriter = writers.FirstOrDefault(x => x.ID == writerid);
            var jsonWriters = JsonConvert.SerializeObject(findwriter);
            return Json(jsonWriters);
        }
        [HttpPost]
        public IActionResult AddWriter(WriterClass writerClass)
        {
            writers.Add(writerClass);
            var jsonWriters = JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }

        public IActionResult DeleteWriter(int id)
        {
            var writer = writers.FirstOrDefault(x => x.ID == id);
            writers.Remove(writer);

            return Json(writer); 
        }

        public IActionResult UpdateWriter(WriterClass writerClass)
        {
            var writer = writers.FirstOrDefault(x => x.ID == writerClass.ID);
            writer.Name = writerClass.Name;
            var jsonWriter = JsonConvert.SerializeObject(writerClass);
            return Json(jsonWriter);

        }

        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                ID = 1,
                Name="Feyza Bakır"
            },
            new WriterClass
            {
                ID = 2,
                Name="Nisa Bakır"
            },
            new WriterClass
            {
                ID = 3,
                Name="Ahmet Kaya"
            },
        };
    }
}
