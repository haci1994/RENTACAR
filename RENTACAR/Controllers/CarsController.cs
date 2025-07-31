using Microsoft.AspNetCore.Mvc;

namespace RENTACAR.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
