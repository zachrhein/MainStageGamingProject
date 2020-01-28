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
    public class NewsController : Controller
    {
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            NewsModel newsModel = await AwaitNews();
            ViewBag.news = newsModel.News;
            return View();
        }
        public async Task<NewsModel> AwaitNews()
        {
            News news = new News();
            return await news.ShowNews();
        }
    }
}
