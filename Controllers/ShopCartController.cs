using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopCar.Data.Interfaces;
using ShopCar.Data.Models;
using ShopCar.ViewModels;

namespace ShopCar.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly ICars _carRepository;
        private readonly ShopCart _shopCart;

        public ShopCartController(ICars repository, ShopCart shopCart)
        {
            _carRepository = repository;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var shopcart = _shopCart.GetCartItems();
            _shopCart.ListCartItems = shopcart;

            var obj = new ShopCartViewModel
            {
                ShopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult AddToCart(int Id)
        {
            var item = _carRepository.GetCars.FirstOrDefault(c => c.Id == Id);
            if(item!=null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}