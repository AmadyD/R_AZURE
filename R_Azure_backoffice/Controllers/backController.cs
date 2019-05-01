using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using R_Azure_backoffice.Models;

namespace R_Azure_backoffice.Controllers
{
    public class backController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<MvcVolModel> volsList;
            HttpResponseMessage response = GlobalVariables.webApiClient.GetAsync("api/Vols").Result;
            volsList = response.Content.ReadAsAsync<IEnumerable<MvcVolModel>>().Result;
            return View(volsList);
        }

        public ActionResult AddOrEdit(int id=7)
        {
            return View(new MvcVolModel());
        }

        [HttpPost]
        public ActionResult AddOrEdit(MvcVolModel vols)
        {
            HttpResponseMessage response = GlobalVariables.webApiClient.PostAsJsonAsync("api/Vols", vols).Result;
            return RedirectToAction("Index");
        }
    }
}