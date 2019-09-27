using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using costadelsoltapas.Models;
using costadelsoltapas.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace costadelsoltapas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITapasRepository _tapasRepository;

        public HomeController(ITapasRepository tapasRepository)
        {
            _tapasRepository = tapasRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                TapasOfTheWeek = _tapasRepository.TapasOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
