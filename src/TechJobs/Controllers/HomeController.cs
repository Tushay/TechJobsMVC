using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TechJobs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //Home page, show search and list options
        {
            Dictionary<string, string> actionChoices = new Dictionary<string, string>();// Adds each actionChoices (what the user can see as choices) into a dictionary
            actionChoices.Add("search", "Search");
            actionChoices.Add("list", "List");
            
            ViewBag.actions = actionChoices;

            return View();
        }
    }
}
