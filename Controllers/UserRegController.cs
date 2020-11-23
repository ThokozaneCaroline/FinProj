using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinProj.Models;

namespace FinProj.Controllers
{
    public class UserRegController : Controller
    {


        //READ CONTENTS FOR USER REGISTRATION
        private readonly AppUserClass _auc;

        public UserRegController(AppUserClass auc)
        {
            _auc = auc;
            return;

        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserClass uc)
        {
            _auc.Add(uc);
            _auc.SaveChanges();
            ViewBag.message = "The user " + uc.Username + "Is Saved Successfully ";
            return View();
        }


    }
}
