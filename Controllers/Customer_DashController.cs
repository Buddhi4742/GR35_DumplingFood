using Dumpling_Food.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Dumpling_Food.Controllers
{
        
    public class Customer_DashController : Controller
    {
        private readonly ILogger<Customer_DashController> _logger;

        public Customer_DashController(ILogger<Customer_DashController> logger)
        {
            _logger = logger;
        }

        public IActionResult Chome()
        {
            return View();
        }

        public IActionResult Recommended()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
