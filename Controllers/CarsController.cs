using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopCar.Data.Interfaces;
using ShopCar.Data.Models;
using ShopCar.ViewModels;

namespace ShopCar.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICars _cars;
        private readonly ICategory _category;

        public CarsController(ICars cars, ICategory category)
        {
            _cars = cars;
            _category = category;
        }
       
        [Authorize]
        public IActionResult Index()
        {
            return Content(User.Identity.Name);
        }

        [Route("Cars/ListCars")]
        [Route("Cars/ListCars/{category}")]
        public ViewResult ListCars(string category)
        {
            IEnumerable<Car> cars = null;
            string carCategory = "";
            if(string.IsNullOrEmpty(category))
            {
                cars = _cars.GetCars.OrderBy(i => i.Id);
            }
            else
            {
                if(string.Equals("Benzin", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _cars.GetCars.Where(x => x.Category.CategoryName.Equals("Benzin"))
                        .OrderBy(i=>i.Id);
                }
                else if(string.Equals("Dizel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _cars.GetCars.Where(x => x.Category.CategoryName.Equals("Dizel"))
                        .OrderBy(i => i.Id);
                }
                else
                {
                    cars = _cars.GetCars.Where(x => x.Category.CategoryName.Equals("Electro"))
                        .OrderBy(i => i.Id);
                }

                carCategory = category;              
            }

            var carObj = new CarsListViewModel
            {
                GetCars = cars,
                CarCategory = carCategory
            };

            ViewBag.Title = "All Cars";
            //CarsListViewModel obj = new CarsListViewModel();
            //obj.GetCars = _cars.GetCars;
            //obj.CarCategory = "auto";

            return View(carObj);
        }
    }
}