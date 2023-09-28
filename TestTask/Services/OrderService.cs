using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Order> GetHighPriceOrder()
        {
            var highPriceOrder = await _dbContext.Orders
                .OrderByDescending(o => o.Price)
                .FirstOrDefaultAsync();

            return highPriceOrder;
        }

        public async Task<List<Order>> GetOrdersWithQuantityMoreTen()
        {
            var ordersWithQuantityMoreTen = await _dbContext.Orders
                .Where(o => o.Quantity > 10)
                .ToListAsync();

            return ordersWithQuantityMoreTen;
        }
    }
}
