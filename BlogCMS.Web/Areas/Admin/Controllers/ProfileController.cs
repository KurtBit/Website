﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogCMS.Data;
using BlogCMS.Web.Areas.Admin.InputModel;
using Microsoft.AspNet.Identity;

namespace BlogCMS.Web.Areas.Admin.Controllers
{
    public class ProfileController : Controller
    {
        private BlogContext context = new BlogContext();

        // GET: Admin/Profile
        [HttpGet]
        public ActionResult Index()
        {
            var model = new ProfileInputModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(ProfileInputModel model)
        {
            var user = context.Users.FirstOrDefault(x => x.IdentityId == User.Identity.GetUserId());// needs to authenticate

            user.AvatarUrl = model.AvatarUrl;

            context.Users.AddOrUpdate(user);

            return View();
        }
    }
}