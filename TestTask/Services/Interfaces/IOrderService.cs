using TestTask.Models;

namespace TestTask.Services.Interfaces
{
    public interface IOrderService
    {
        public Task<Order> GetHighPriceOrder();

        public Task<List<Order>> GetOrdersWithQuantityMoreTen();
    }
}
