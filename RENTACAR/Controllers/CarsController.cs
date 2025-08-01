using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RENTACAR.DataContext;
using RENTACAR.Models;

namespace RENTACAR.Controllers
{
    public class CarsController : Controller
    {
        private readonly AppDbContext _dataContext;

        public CarsController(AppDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var carsCount = _dataContext.Cars.Include(x => x.Model)
                .Include(f => f.carImages)
                .Include(h => h.Model.Brand)
                .Include(z => z.Model.CarType)
                .ToList()
                .Count();

            var cars = _dataContext.Cars.Include(x => x.Model)
                .Include(f => f.carImages)
                .Include(h => h.Model.Brand)
                .Include(z => z.Model.CarType)
                .Take(3)
                .ToList();

            var model = new CarsViewModel { Cars = cars, CarCount = carsCount};

            return View(model);
        }

        public IActionResult _CarsLoadMorePartialView(int skip)
        {
            var cars = _dataContext.Cars.Include(x => x.Model)
                .Include(f => f.carImages)
                .Include(h => h.Model.Brand)
                .Include(z => z.Model.CarType)
                .Skip(skip)
                .Take(3)
                .ToList();

            //var model = new CarsPartialLoadModel { Cars = cars };

            return PartialView("_CarsLoadMorePartialView", cars);
        }
    }
}
