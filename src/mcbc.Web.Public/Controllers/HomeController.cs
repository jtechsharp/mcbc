using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mcbc.Web.Public.Models;
using mcbc.Controllers;

namespace mcbc.Web.Public.Controllers
{
    public class HomeController : mcbcControllerBase
    {
        
        public IActionResult Index()
        {
            return View();
        }

    }
}