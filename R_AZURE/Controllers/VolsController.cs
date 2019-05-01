using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace R_AZURE.Controllers
{
    public class VolsController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<MvcVolsModel> volsList;
            HttpResponseMessage response = GlobalVariables.webApiClient.GetAsync("api/Vols").Result;
            volsList = response.Content.ReadAsAsync<IEnumerable<MvcVolsModel>>().Result;
            return View(volsList);
        }
    }
}