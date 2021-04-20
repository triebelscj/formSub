using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FormSubmission.Models;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("user/create")]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                return View("Success");
            }
            else
            {
                return View("Index");
            }
        }
    }
}