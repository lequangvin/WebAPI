using FriendsForever.Services;
using FriendsForever.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FriendsForever.Controllers
{
    public class SecurityController : Controller
    {
        private ISecurityService _service = null;
        public SecurityController(ISecurityService service)
        {
            _service = service;
        }
        // GET: Security
        public ActionResult Logon()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View(); 
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                _service.SaveUserToDB(model);
                return View();
            }
            return View(model);
        }
    }
}