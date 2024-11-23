using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;

namespace MyPortfolioProject.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
    }
}
