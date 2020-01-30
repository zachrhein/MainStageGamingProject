using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainStageGamingProject.ApiModels;
using MainStageGamingProject.Models;
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

        public async Task<IActionResult> Stats()
        {
            EpicStatsModel epicStatsModel = await ShowStats();
            ViewBag.statistics = epicStatsModel.Global_Stats;
            return View();
        }
        public async Task<EpicStatsModel> ShowStats()
        {
            StatsProcessor statsProcessor = new StatsProcessor();

            return await statsProcessor.LoadStats();
        }


    }
}
