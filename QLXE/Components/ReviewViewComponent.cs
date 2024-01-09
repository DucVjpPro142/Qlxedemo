using Microsoft.AspNetCore.Mvc;
using QLXE.Models;
namespace QLXE.Components
{
    [ViewComponent(Name = "Review")]
    public class ReviewViewComponent : ViewComponent
    {
        private readonly DataContext _context;
        public ReviewViewComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofReview = (from r in _context.Reviews
                                where r.IsActive == true
                                orderby r.ReviewsID descending
                                select r).Take(3).ToList();

            return await Task.FromResult((IViewComponentResult)View("Default", listofReview));
        }
    }
}
