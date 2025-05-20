using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Villa.MVC.DAL.Contexts;
using Villa.MVC.DAL.Models;

namespace Villa.MVC.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController()
        {
            _context = new AppDbContext();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tables()
        {
            List<VillaModel> list = _context.VillaModels.ToList();
            return View(list);
        }

        
    }
}
