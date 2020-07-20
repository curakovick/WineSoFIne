using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using WineSoFine.Migrations;
using WineSoFine.Models;
using WineSoFine.ViewModels;

namespace WineSoFine.Controllers
{
    public class WinesController : Controller
    {
        private ApplicationDbContext _context;

        public WinesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var wines = _context.Wines.Include(m => m.Type);
            return View(wines);
        }

        public ActionResult Details(int id)
        {
            var wine = _context.Wines.Include(m => m.Type).SingleOrDefault(m => m.Id == id);
            if (wine == null)
                return HttpNotFound();
            return View(wine);
        }

        public ViewResult New()
        {
            var types = _context.WineTypes.ToList();

            var viewModel = new RandomWineViewModel
            {
                Types = types
            };
            return View("WineForm", viewModel);
        }


        public ActionResult Edit(int id)
        {
            var wine = _context.Wines.SingleOrDefault(c => c.Id == id);
            if (wine == null)
                return HttpNotFound();
            var viewModel = new WineFormViewModel
            {
                Wine=wine,
                Type = _context.WineTypes.ToList()
            };
            return View("MovieForm", viewModel);
        }
    }
}