using Microsoft.AspNetCore.Mvc;
using Villa.MVC.DAL.Contexts;
using Villa.MVC.DAL.Models;

namespace Villa.MVC.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController()
        {
            _context = new AppDbContext();
        }

        public IActionResult Index()
        {
            List<VillaModel> list = _context.VillaModels.ToList();
            return View(list);
        }

    }
}
