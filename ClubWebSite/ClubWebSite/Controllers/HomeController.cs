﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClubWebSite.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 详细信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("item/{id}")]
        public IActionResult Details(int id)
        {
            ViewData["Message"] = "Your application description page."+id;

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
