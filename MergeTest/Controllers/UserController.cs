using MergeTest.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace MergeTest.Controllers
{
    public class UserController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        ApplicationUser user = new ApplicationUser();

        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                string userId = User.Identity.GetUserId();
                user = db.Users
                    .Where(u => u.Id == userId)
                    .FirstOrDefault();

                return View(user);
            }

            return RedirectToAction("Index", "Home");

        }

        [Route("send/{username}")]
        public ActionResult Index(string username)
        {
            user = db.Users
                .Where(u => u.UserName == username)
                .FirstOrDefault();

            return View(user);
        }
    }
}
