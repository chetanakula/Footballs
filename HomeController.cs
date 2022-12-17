using Footballs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Footballs.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        MyDbContext context = new MyDbContext();
        public ActionResult Index()
        {
            return View(context.Footballleagu);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult CreatenewAccount(Match b)
        {
            //if (b.MatchID < 0)
            {
               // ModelState.AddModelError("MatchID", "MatchId cnnot be negative");
            }
           // if (string.IsNullOrEmpty(b.TeamName1))
            {
               // ModelState.AddModelError("TeamName1", "TeamName1 is required");
            }
           // if (string.IsNullOrEmpty(b.TeamName2))
            {
               // ModelState.AddModelError("TeamName2", "TeamName2 is required");
            }
           // if (string.IsNullOrEmpty(b.Status))
            {
               // ModelState.AddModelError("Status", "Status must be either win or draw");
            }
            if(ModelState.IsValid)
            {
                context.Footballleagu.Add(b);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create");
        }
    }
}