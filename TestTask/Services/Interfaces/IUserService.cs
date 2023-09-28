using TestTask.Models;

namespace TestTask.Services.Interfaces
{
    public interface IUserService
    {
        public Task<User> GetUserWithHighOrdersCount();

        public Task<List<User>> GetInactiveUsers();
    }
}
