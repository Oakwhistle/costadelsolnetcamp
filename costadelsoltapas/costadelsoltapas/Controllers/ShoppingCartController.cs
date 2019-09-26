using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using costadelsoltapas.Models;
using Microsoft.AspNetCore.Mvc;

namespace costadelsoltapas.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ITapasRepository _tapasRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ITapasRepository tapasRepository, ShoppingCart shoppingCart)
        {
            _tapasRepository = tapasRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int tapasID)
        {
            var selectedTapa = _tapasRepository.AllTapas.FirstOrDefault(p => p.TapasID == tapasID);

            if (selectedTapa != null)
            {
                _shoppingCart.AddToCart(selectedTapa, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int tapasID)
        {
            var selectedTapa = _tapasRepository.AllTapas.FirstOrDefault(p => p.TapasID == tapasID);

            if (selectedTapa != null)
            {
                _shoppingCart.RemoveFromCart(selectedTapa);
            }
            return RedirectToAction("Index");
        }
    }
}
