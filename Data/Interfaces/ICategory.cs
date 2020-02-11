using ShopCar.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCar.Data.Interfaces
{
    public interface ICategory
    {
        IEnumerable<Category> Categories { get; }
    }
}
