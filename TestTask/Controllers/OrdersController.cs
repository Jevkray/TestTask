using Microsoft.AspNetCore.Mvc;
using TestTask.Services.Interfaces;

namespace TestTask.Controllers
{
    /// <summary>
    /// Orders controller.
    /// DO NOT change anything here. Use created contract and provide only needed implementation.
    /// </summary>
    [Route("api/v1/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrdersController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        /// <summary>
        /// Returns selected order. 
        /// Selection rules are specified in Task description provided by recruiter
        /// </summary>
        [HttpGet]
        [Route("selected-order-with-high-price")]
        public async Task<IActionResult> Get()
        {
            var result = await this.orderService.GetHighPriceOrder();
            return this.Ok(result);
        }

        /// <summary>
        /// Returns list of selected orders. 
        /// Selection rules are specified in Task description provided by recruiter
        /// </summary>
        [HttpGet]
        [Route("selected-orders-with-quantity-more-ten")]
        public async Task<IActionResult> GetOrders()
        {
            var result = await this.orderService.GetOrdersWithQuantityMoreTen();
            return this.Ok(result);
        }
    }
}
