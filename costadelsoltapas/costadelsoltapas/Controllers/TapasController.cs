using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using costadelsoltapas.Models;
using costadelsoltapas.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace costadelsoltapas.Controllers
{
    public class TapasController : Controller
    {
        private readonly ITapasRepository _tapasRepository;
        private readonly ICategoryRepository _categoryRepository;

        public TapasController(ITapasRepository tapasRepository, ICategoryRepository categoryRepository)
        {
            _tapasRepository = tapasRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Tapas> tapas;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                tapas = _tapasRepository.AllTapas.OrderBy(p => p.TapasId);
                currentCategory = "All tapas";
            }
            else
            {
                tapas = _tapasRepository.AllTapas.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.TapasId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new TapasListViewModel
            {
                Tapas = tapas,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        {
            var tapas = _tapasRepository.GetTapasById(id);
            if (tapas == null)
                return NotFound();

            return View(tapas);
        }
    }
}
