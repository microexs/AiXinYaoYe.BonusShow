﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using AiXinYaoYe.Database;

namespace AiXinYaoYe.Controllers
{
    public class ProfileController : Controller
    {
        public ActionResult Index()
        {
            string openID = "123";
            var userProfile = AiXinYaoYeDb.GetUserProfile(openID);
            return View(userProfile);
        }
    }
}
