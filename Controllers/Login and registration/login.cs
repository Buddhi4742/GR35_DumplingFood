using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dumpling_Food.Controllers.Login_and_registration
{
    public class Login : Controller
    {
        // GET: login
        public IActionResult Userlogin()
        {
            return View();
        }
        public IActionResult Userregister()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: login/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: login/Edit/5
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

        // GET: login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: login/Delete/5
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
