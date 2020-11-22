using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinProj.Models;

namespace FinProj.Controllers
{
    public class UserRegController1 : Controller
    {
        private readonly AppUserClass _auc;

        public UserRegController1(AppUserClass auc)
        {
            _auc = auc;
        }
        public IActionResult Index()
        {
            return View();
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
            ViewBag.message = "The user " + uc.Username + " is saved successfully!";
            return View();
        }
    }
}
