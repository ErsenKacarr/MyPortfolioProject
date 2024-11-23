using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;

namespace MyPortfolioProject.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }
    }
}
