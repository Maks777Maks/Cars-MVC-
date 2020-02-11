using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopCar.Data.EFContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCar.Data.Models
{
    public class ShopCart
    {
        private readonly EFDbContext _context;

        public ShopCart(EFDbContext context)
        {
            _context = context;
        }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> ListCartItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session; // create new session
            var context = services.GetService<EFDbContext>();
            string shopcartId = session.GetString("cartId") ?? Guid.NewGuid().ToString();

            session.SetString("cartId", shopcartId);

            return new ShopCart(context) { ShopCartId = shopcartId };
        }

        public void AddToCart(Car car)
        {
            this._context.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                Car = car,
                Price = car.Price
            });

            _context.SaveChanges();
        }

        public List<ShopCartItem> GetCartItems()
        {
            return _context.ShopCartItem.Where(x => x.ShopCartId == ShopCartId)
                .Include(c => c.Car)
                .ToList();
        }
    }
}
