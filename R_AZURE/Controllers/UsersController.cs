using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using R_AZURE.Models;

namespace R_AZURE.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index(int id=0)
        {
            return View(new MvcUserModel());
        }
    }
}