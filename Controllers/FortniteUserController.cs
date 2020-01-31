using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainStageGamingProject.ApiModels;
using MainStageGamingProject.Models;
using MainStageGamingProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MainStageGamingProject.Controllers
{
    public class FortniteUserController : Controller
    {
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            EpicNameModel epicNameModel = await GetUserID("BustaRhein");

            ViewBag.username = epicNameModel.Account_id;
            return View();
        }

        public async Task<EpicNameModel> GetUserID(string username) 
        {
            FindUser fortniteUser = new FindUser(username);
            
            return await fortniteUser.FindUserID();
        }
        public IActionResult SearchUsername()
        {
            ViewBag.name = "";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SearchUsername(SearchViewModel searchViewModel)
        {
            if (ModelState.IsValid)
            {
                FindUser findUser = new FindUser(searchViewModel.Username);
                EpicNameModel epicNameModel = await findUser.FindUserID();
                StatsProcessor statsProcessor = new StatsProcessor();
                EpicStatsModel epicStatsModel = await statsProcessor.LoadStats(epicNameModel);
                if (epicStatsModel.Global_Stats != null & epicStatsModel.Name != null)
                {
                    ViewBag.name = epicStatsModel.Name;
                    ViewBag.statistics = epicStatsModel.Global_Stats;
                    return View();
                }
                ViewBag.name = "User does not exist.";
            }
            return View();
        }

    }
}
