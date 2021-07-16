﻿using Dumpling_Food.Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// ///////////////////////////////////////////////// carcontroller.cs controller file
/// </summary>
namespace Dumpling_Food.Controllers
{
    public class UserController : Controller
    {
        private readonly Services.DbServices dbServices;

        public UserController(Services.DbServices dbServices)
        {
            this.dbServices = dbServices;
        }

        // GET: UserController
        //public ActionResult UserView()
        //{
        //    return View(dbServices.Get());
        //}
        public IActionResult UserView()
        {
            return View(dbServices.Get());
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult UserProfile()
        {
            return View();
        }
       
        public ActionResult Logincheck(IFormCollection collection)
        {
            //if (collection["userName"] == null)
            //{
            //    return NotFound();
            //}
            var Loginmodel = new LoginModel();

            Loginmodel = dbServices.Getbylogindetails(collection["userName"], collection["password"]);
            if (Loginmodel == null)
            {
                return NotFound();
            }
            //Loginmodel.userName = collection["userName"];
            //Loginmodel.custName = collection["custName"];
            //Loginmodel.custId = collection["custID"];
            //var user = dbServices.Get(collection["userName"]);
            //if (user == null)
            //{
            //    return NotFound();
            //}
            return View(Loginmodel);
        }

        // GET: UserController/Create
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Models.User.LoginModel user)
        {
            if (ModelState.IsValid)
            {
                dbServices.Create(user);
                return RedirectToAction(nameof(UserView));
            }
            return View(user);
        }



        // POST: UserController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}