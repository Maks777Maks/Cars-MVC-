using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopCar.Data.Interfaces;
using ShopCar.Models;
using ShopCar.ViewModels;

namespace ShopCar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICars _cars;
        private readonly ICategory _category;

        public HomeController(ICars cars, ICategory category)
        {
            _cars = cars;
            _category = category;
        }

        public ViewResult Index()
        {
            var cars = new HomeViewModel
            {
                CarAvailabel = _cars.GetAvCars
            };
            return View(cars);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
