using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;

namespace MyPortfolioProject.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {

            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.v5 = context.Testimonials.Count();
            ViewBag.v6 = context.SocialMedias.Count();
            ViewBag.v7 = context.ToDoLists.Count();
            ViewBag.v8 = context.Portfolios.Count();
            ViewBag.v9 = context.Features.Count();
            ViewBag.v10 = context.Contacts.Count();
            ViewBag.v11 = context.Experiences.Count();
            ViewBag.v12 = context.Abouts.Count();
            return View();
        }
    }
}
