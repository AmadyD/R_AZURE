using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using R_AZURE.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace R_AZURE.Controllers
{
    public class VolController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //VolModel [] VolModel = new VolModel();
            var VolModel = new VolModel("D455G","Paris","Porto Seguro", new DateTime(2019, 6, 1, 7, 47, 0), new DateTime(2019, 6, 1, 7, 47, 0),1500);
           



            return View(VolModel);
        }

        //Afficher vol par id
        //[Route("VolDetail/{id}/{title}")]
        public IActionResult VolDetail(int id,string title)
        {
            ViewBag.VolId = id;
            ViewBag.VolTitle = title;
            return View();
        }

    }
}
