using dotMemo.Entities;
using dotMemo.Repositories;

namespace dotMemo.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> GetUserByEmail(string userEmail);

        public Task<User> CreateUser(User user);

        public Task<User> UpdateUser(User user);
    }
}
