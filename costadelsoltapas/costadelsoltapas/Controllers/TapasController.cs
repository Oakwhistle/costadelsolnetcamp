using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using costadelsoltapas.Models;
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

        public ViewResult List()
        {
            return View(_tapasRepository.AllTapas);
        }
    }
}