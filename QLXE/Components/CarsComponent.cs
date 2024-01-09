using Microsoft.AspNetCore.Mvc;
using QLXE.Models;
namespace QLXE.Components
{
    [ViewComponent(Name = "Cars")]
    public class CarsComponent : ViewComponent
    {
        private readonly DataContext _context;
        public CarsComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofCars = (from c in _context.Cars
                              where (c.IsActive == true) && (c.Status == 1)
                              orderby c.CarId descending
                              select c).Take(3).ToList();

            return await Task.FromResult((IViewComponentResult)View("Default", listofCars));
        }
    }
}
