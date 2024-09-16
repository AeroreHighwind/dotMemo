using dotMemo.Entities;
using dotMemo.Repositories;

namespace dotMemo.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> GetUser(int userId);

        public Task<User> CreateUser(User user);

        public Task<User> UpdateUser(User user);
    }
}
