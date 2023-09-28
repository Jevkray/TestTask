using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using TestTask.Data;
using TestTask.Enums;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _dbContext;

        public UserService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> GetUserWithHighOrdersCount()
        {
            var userWithHightOrdersCount = await _dbContext.Users.
                OrderByDescending(x => x.Orders.Count).
                FirstOrDefaultAsync();

            return userWithHightOrdersCount;
        }

        public async Task<List<User>> GetInactiveUsers()
        {
            var inactiveUsers = await _dbContext.Users
                .Where(u => u.Status == UserStatus.Inactive)
                .ToListAsync();

            return inactiveUsers;
        }
    }
}
