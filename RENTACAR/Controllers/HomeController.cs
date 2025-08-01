using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RENTACAR.DataContext;
using RENTACAR.Models;

namespace RENTACAR.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var cars = _dbContext.Cars.Where(x=> x.Price < 201).Include(z=>z.carImages).Include(h=>h.Model).ThenInclude(y=> y.Brand).ToList();
            var contacts = _dbContext.ContactInfos.ToList();

            var model = new HomeViewModel { Cars = cars, Contacts = contacts};

            return View(model);
        }
    }
}
