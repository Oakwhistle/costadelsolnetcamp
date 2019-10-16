using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using costadelsoltapas.Models;
using costadelsoltapas.ViewModels;
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

        public RedirectToActionResult AddToShoppingCart(int tapasId)
        {
            var selectedTapa = _tapasRepository.AllTapas.FirstOrDefault(p => p.TapasId == tapasId);

            if (selectedTapa != null)
            {
                _shoppingCart.AddToCart(selectedTapa, 1);
            }
            return RedirectToAction("Index");
        }

        [Route("/ShoppingCart/Remove", Name = "Remove")]
        public RedirectToActionResult RemoveFromShoppingCart(int id) // tapasId
        {
            var selectedTapa = _tapasRepository.GetTapasById(id);
            //var selectedTapa = _tapasRepository.AllTapas.FirstOrDefault(p => p.TapasId == tapasId);

            if (selectedTapa != null)
            {
                _shoppingCart.RemoveFromCart(selectedTapa);
            }

            // ViewBag.RemoveMessage = "The item has been succesfully removed from your shopping cart!";
            return RedirectToAction("Index");
        }

        public RedirectToActionResult IncreaseAmount(int id)
        {
            var selectedTapa = _tapasRepository.GetTapasById(id);

            if (selectedTapa != null)
            {
                _shoppingCart.AddToCart(selectedTapa, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();

            return RedirectToAction("Index");
        }

    }
}
