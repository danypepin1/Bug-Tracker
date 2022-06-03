using Microsoft.AspNetCore.Mvc;
using System;

namespace BugTracker.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Test()
        {
            return Ok("success");
        }
    }
}
