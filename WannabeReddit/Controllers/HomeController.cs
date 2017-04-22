﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WannabeReddit.Models;
using WannabeReddit.Services;

namespace WannabeReddit.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();


        public ActionResult Index(int pageIndex = 1, int pageSize = 3)
        {

            var posts = db.Posts
                .OrderByDescending(o => o.DatePosted)
                .Skip((pageIndex - 1) * pageSize).
                Take(pageSize).ToList();

            return View(posts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}