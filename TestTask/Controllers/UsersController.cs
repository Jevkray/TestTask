using Microsoft.AspNetCore.Mvc;
using TestTask.Services.Interfaces;

namespace TestTask.Controllers
{
    /// <summary>
    /// Users controller.
    /// DO NOT change anything here. Use created contract and provide only needed implementation.
    /// </summary>
    [Route("api/v1/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        /// <summary>
        /// Returns selected user. 
        /// Selection rules are specified in Task description provided by recruiter
        /// </summary>
        [HttpGet]
        [Route("selected-user-with-high-orders-count")]
        public async Task<IActionResult> Get()
        {
            var result = await this.userService.GetUserWithHighOrdersCount();
            return this.Ok(result);
        }

        /// <summary>
        /// Returns list of selected users. 
        /// Selection rules are specified in Task description provided by recruiter
        /// </summary>
        [HttpGet]
        [Route("selected-inactive-users")]
        public async Task<IActionResult> GetUsers()
        {
            var result = await this.userService.GetInactiveUsers();
            return this.Ok(result);
        }
    }
}
