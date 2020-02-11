using ShopCar.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCar.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> CarAvailabel { get; set; }
    }
}
