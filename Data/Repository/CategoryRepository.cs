using ShopCar.Data.EFContext;
using ShopCar.Data.Interfaces;
using ShopCar.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCar.Data.Repository
{
    public class CategoryRepository: ICategory
    {
        private readonly EFDbContext _context;

        public CategoryRepository(EFDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Categories => _context.Categories;
    }
}
