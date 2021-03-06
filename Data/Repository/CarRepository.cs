﻿using Microsoft.EntityFrameworkCore;
using ShopCar.Data.EFContext;
using ShopCar.Data.Interfaces;
using ShopCar.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCar.Data.Repository
{
    public class CarRepository: ICars
    {
        private readonly EFDbContext _context;

        public CarRepository(EFDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetCars => _context.Cars.Include(x => x.Category);

        public IEnumerable<Car> GetAvCars => _context.Cars
            .Where(p => p.Availabel)
            .Include(x => x.Category);

        public Car GetCar(int CarId) => _context.Cars.FirstOrDefault(c => c.Id == CarId);
    }
}
