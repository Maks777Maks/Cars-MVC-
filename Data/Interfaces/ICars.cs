using ShopCar.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCar.Data.Interfaces
{
    public interface ICars
    {
        IEnumerable<Car> GetCars { get; }
        IEnumerable<Car> GetAvCars { get; }
        Car GetCar(int Id);
    }
}
