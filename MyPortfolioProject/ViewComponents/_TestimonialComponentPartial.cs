using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DAL.Context;

namespace MyPortfolioProject.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }
    }
}
